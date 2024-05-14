using log4net;
using Microsoft.Deployment.Compression.Cab;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Shell32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using eSupportHelper;

namespace LUC_eSupportCompare
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Hook for the global log file
        /// </summary>
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Holds the current column that is sorted, updated on every attempt to sort
        /// </summary>
        int newSortColumn;

        /// <summary>
        /// Default sort is ascending, will be flipped back and forth if reordering columns
        /// </summary>
        ListSortDirection newColumnDirection = ListSortDirection.Ascending;

        /// <summary>
        /// List of all the models available on esupport
        /// </summary>
        List<ModelInformation> modelInfo;

        /// <summary>
        /// Flags for the configurable options
        /// </summary>
        bool preventCRCEXE = true;
        bool preventCRCXML = true;
        bool exportToExcel = false;

        /// <summary>
        /// Lists to hold the data we get from esupport and system update
        /// </summary>
        List<DownloadItem> su;
        List<DownloadItem> eSupport;

        /// <summary>
        /// List to hold the beginning of the names of packages we want to exclude
        /// </summary>
        List<string> excludePackages = new List<string>();

        /// <summary>
        /// List to hold the names of columns we want to exclude
        /// </summary>
        List<string> excludeColumns = new List<string>();

        /// <summary>
        /// List to hold the issue numbers to be ignored
        /// </summary>
        List<string> hideIssues = new List<string>();

        /// <summary>
        /// Different data output modes, Full is default
        /// </summary>
        enum SilentOutputMode
        {
            Full = 0,
            Warning = 1,
            Error = 2
        }//end SilentOutputMode

        SilentOutputMode mode = SilentOutputMode.Full;

        /// <summary>
        /// Get the location of the current users downloads folder to use as a scratch space
        /// </summary>
        string baseFolder = Path.Combine(KnownFolders.GetPath(KnownFolder.Downloads), Properties.Settings.Default.Name);
        public Form1()
        {
            InitializeComponent();
            log.Info("Setting up the GUI");
            cb_family.Items.Add(Properties.Settings.Default.ThinkPad);
            cb_family.Items.Add(Properties.Settings.Default.ThinkCentre);
            cb_family.Items.Add(Properties.Settings.Default.ThinkStation);
            cb_family.Items.Add(Properties.Settings.Default.IdeaPad);
            cb_os.Items.Add(Properties.Settings.Default.Win10);
            cb_os.SelectedIndex = 0;
            cb_os.Items.Add(Properties.Settings.Default.Win7);
            cb_os.Items.Add(Properties.Settings.Default.Win11);
            toolStripStatusLabel1.Text = "Please select a model to do the compare on...";
            try
            {
                Directory.CreateDirectory(baseFolder);
            }
            catch { }

            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; //TLS 1.2
            modelInfo = GetAllModels();
        }//end constructor

        /// <summary>
        /// Function used to call the command line version of the tool 
        /// </summary>
        /// <param name="file">String path to the file containing the model types</param>
        public void NoGUI(string[] args)
        {
            bool modeSetViaCMD = false;
            List<DataTable> dataTables = new List<DataTable>();
            //Check the cmd line parameters for any output modes
            string file = args[0];
            if (args.Any("error".Contains))
            {
                mode = SilentOutputMode.Error;
                modeSetViaCMD = true;
            }//end if
            if (args.Any("warning".Contains))
            {
                mode = SilentOutputMode.Warning;
                modeSetViaCMD = true;
            }//end if
            if (args.Any("full".Contains))
            {
                mode = SilentOutputMode.Full;
                modeSetViaCMD = true;
            }//end if

            log.Info("Running in " + mode);

            if (!File.Exists(file))
            {
                Console.Out.WriteLine("No file has been found!");
                log.Error("No file was found.");
                return;
            }//end if

            string[] lines = File.ReadAllLines(file);
            string os = "Win10";
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                    continue;
                if (line.Contains("="))
                {
                    string[] splits = line.Split(new char[] { '=', '#' });
                    if (splits[0].Trim().ToUpper().Equals("OS"))
                    {
                        os = splits[1];
                        log.Info("Setting os = " + os);
                    }//end if
                    else if (splits[0].Trim().ToUpper().Equals("CRC_EXE"))
                    {
                        if (splits[1].Trim().ToUpper().Equals("FALSE") && mode != SilentOutputMode.Error)
                        {
                            preventCRCEXE = true;
                            log.Info("Skipping exe crc checks");
                        }//end if
                        else
                        {
                            preventCRCEXE = false;
                            log.Info("Performing exe crc checks");
                        }//end if
                    }//end else if
                    else if (splits[0].Trim().ToUpper().Equals("CRC_XML"))
                    {
                        if (splits[1].Trim().ToUpper().Equals("FALSE") && mode != SilentOutputMode.Error)
                        {
                            preventCRCXML = true;
                            log.Info("Skipping xml crc checks");
                        }//end if
                        else
                        {
                            preventCRCXML = false;
                            log.Info("Performing xml crc checks");
                        }//end else
                    }//end else if
                    else if (splits[0].Trim().ToUpper().Equals("EXPORT"))
                    {
                        if (splits[1].Trim().ToUpper().Equals("EXCEL"))
                            exportToExcel = true;
                    }//end else if
                    else if (splits[0].Trim().ToUpper().Equals("EXCLUDE_COLUMNS"))
                    {
                        foreach (string col in splits[1].Split(','))
                        {
                            excludeColumns.Add(col.Trim());
                        }//end foreach
                    }//end else if
                    else if (splits[0].Trim().ToUpper().Equals("EXCLUDE_PACKAGES"))
                    {
                        foreach (string col in splits[1].Split(','))
                        {
                            excludePackages.Add(col.Trim());
                        }//end foreach
                    }//end else if
                    else if (splits[0].Trim().ToUpper().Equals("HIDE_ISSUES"))
                    {
                        foreach (string col in splits[1].Split(','))
                        {
                            hideIssues.Add(col.Trim());
                        }//end foreach
                    }//end else if
                    else if (splits[0].Trim().ToUpper().Equals("ONLY_ISSUES"))
                    {
                        if (splits[1].Trim().ToUpper().Equals("TRUE") && !modeSetViaCMD)
                        {
                            mode = SilentOutputMode.Warning;
                        }//end if
                    }//end else if
                }//end if
                else
                {
                    string model = line.Substring(0, 4);
                    log.Info("Processing model: " + model);
                    if (modelInfo.Any(x => x.getMTM().Equals(model)))
                    {
                        string path = baseFolder + @"\" + model + "_" + os + ".txt";
                        log.Info("Creating result file at: " + path);
                        // This text is added only once to the file.
                        if (!File.Exists(path) && !exportToExcel)
                        {
                            // Create a file to write to.
                            using (StreamWriter sw = File.CreateText(path))
                            {
                                sw.WriteLine("Issues\tpackage\tname\teSupportVersion\teSupportExeLink\teSupportDSLink\teSupportReleaseDate\teSupportHash\teSupportCategory" +
                                    "\tsuVersion\tsuExeLink\tsuCatalogLink\tsuReleaseDate\tsuGivenXMLHash\tsuComputedXMLHash\tsuGivenEXEHash\tsuComputedEXEHash" +
                                    "\tsuCategory\tlucVersion");
                            }//end using StreamWriter
                        }//end if
                        Console.Out.WriteLine(line);
                        try
                        {
                            List<DGRow> rows = silentRun(line, os);
                            if (!exportToExcel)
                            {
                                using (StreamWriter sw = File.AppendText(path))
                                {
                                    foreach (DGRow row in rows)
                                    {
                                        if (mode == SilentOutputMode.Error)
                                        {
                                            if (row.Issues.Contains("5") || row.Issues.Contains("6"))
                                                sw.WriteLine(row.ToDelimitedString());
                                        }//end if
                                        else if (mode == SilentOutputMode.Warning)
                                        {
                                            if (!string.IsNullOrWhiteSpace(row.Issues))
                                                sw.WriteLine(row.ToDelimitedString());
                                        }//end else if
                                        else
                                            sw.WriteLine(row.ToDelimitedString());
                                    }//end foreach
                                }//end using
                            }//end if
                            else
                            {
                                /*downloadLUC();
                                XmlDocument doc = new XmlDocument();
                                doc.Load(Path.Combine(baseFolder, Properties.Settings.Default.LucFolder, Properties.Settings.Default.CatalogName));
                                XmlNamespaceManager manager = new XmlNamespaceManager(doc.NameTable);
                                manager.AddNamespace("smc", "http://schemas.microsoft.com/sms/2005/04/CorporatePublishing/SystemsManagementCatalog.xsd");
                                manager.AddNamespace("bar", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/BaseApplicabilityRules.xsd");
                                manager.AddNamespace("bt", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/BaseTypes.xsd");
                                manager.AddNamespace("cmd", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/Installers/CommandLineInstallation.xsd");
                                manager.AddNamespace("lar", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/LogicalApplicabilityRules.xsd");
                                manager.AddNamespace("msi", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/Installers/MsiInstallation.xsd");
                                manager.AddNamespace("msiar", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/MsiApplicabilityRules.xsd");
                                manager.AddNamespace("msp", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/Installers/MspInstallation.xsd");
                                manager.AddNamespace("sdp", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/SoftwareDistributionPackage.xsd");
                                manager.AddNamespace("uei", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/Installers/UpdateExeInstallation.xsd");
                                manager.AddNamespace("usp", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/UpdateServicesPackage.xsd");
                                manager.AddNamespace("drv", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/Installers/WindowsDriver.xsd");
                                manager.AddNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance");

                                foreach (DGRow row in rows)
                                {
                                    try
                                    {
                                        string xpath = string.Format("/smc:SystemsManagementCatalog/smc:SoftwareDistributionPackage/sdp:InstallableItem/sdp:OriginFile[@FileName='{0}']/../..", (row.package));
                                        XmlNode node = doc.SelectSingleNode(xpath, manager);
                                        if (node != null)
                                        {
                                            row.lucVersion = "View XML";
                                            row.lucXML = node.OuterXml;
                                        }//end if
                                        else
                                        {
                                            row.lucVersion = "";
                                            row.lucXML = "";
                                        }//end else
                                    }
                                    catch (XPathException e)
                                    {
                                        MessageBox.Show(e.Message);
                                        row.lucVersion = "";
                                    }//end catch
                                }//end foreach
                                */
                                // storing header part in Excel  
                                rows.Sort((p, q) => p.name.CompareTo(q.name));
                                ListtoDataTable ltod = new ListtoDataTable();
                                DataTable dt = ltod.ToDataTable(rows).DefaultView.ToTable(true);
                                dt.Columns["Issues"].SetOrdinal(0);
                                foreach (string col in excludeColumns)
                                {
                                    dt.Columns.Remove(col);
                                }//end foreach
                                if (mode == SilentOutputMode.Warning)
                                {
                                    for (int i = dt.Rows.Count - 1; i >= 0; i--)
                                    {
                                        DataRow dr = dt.Rows[i];

                                        if (dr["Issues"] == DBNull.Value)
                                        {
                                            dr.Delete();
                                        }//end if
                                    }//end for
                                }//end if
                                if (hideIssues.Count > 0)
                                {
                                    for (int i = dt.Rows.Count - 1; i >= 0; i--)
                                    {
                                        DataRow dr = dt.Rows[i];

                                        if (dr["Issues"] == DBNull.Value)
                                            continue;
                                        string issues = (string)dr["Issues"];
                                        foreach (string hide in hideIssues)
                                        {
                                            issues = issues.Replace(hide, " ");
                                        }//end foreach

                                        if (string.IsNullOrWhiteSpace(issues))
                                            dr.Delete();
                                        else
                                            dr["Issues"] = issues;
                                    }//end for
                                }//end if

                                dt.AcceptChanges();
                                dataTables.Add(dt);
                                dt.ExportToExcel(Path.Combine(baseFolder, model + "_" + os + ".xls"));
                            }//end else
                        }//end try
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                            MessageBox.Show(e.StackTrace);
                            log.Error(e.Message);
                        }//end catch
                    }//end if
                    else
                    {
                        Console.Out.WriteLine(line.Substring(0, 4) + " is not a valid MTM");
                        log.Error(line.Substring(0, 4) + " is not a valid MTM");
                    }//end else
                    toolStripProgressBar1.Value = 0;
                }//end else
            }//end foreach
            DataTable master = new DataTable();
            foreach (DataTable d in dataTables)
            {
                master.Merge(d);
            }
            var result = master.AsEnumerable()
            .GroupBy(r => new
            {
                issues = r.Field<string>("issues"),
                name = r.Field<String>("name"),
                package = r.Field<String>("package"),
                eSupportVersion = r.Field<String>("eSupportVersion"),
                suVersion = r.Field<String>("suVersion"),
                //lucXML = r.Field<String>("lucXML"),
                suReleaseDate = r.Field<String>("suReleaseDate")
            })
            .Select(r => new
            {
                r.Key.issues,
                r.Key.name,
                r.Key.package,
                r.Key.eSupportVersion,
                r.Key.suVersion,
                model = String.Join(",", r.Select(z => z.Field<string>("model"))),
                r.Key.suReleaseDate,
                //r.Key.lucXML
            });
            result.CopyToDataTable().ExportToExcel(baseFolder + "\\all.xls");
            //master.ExportToExcel(baseFolder + "\\allNoGroup.xls");

            Console.Out.WriteLine("Completed all tasks!");
            Console.Out.WriteLine("Press any Enter to close...");
            //Console.In.ReadLine();
        }//end NoGUI

        /// <summary>
        /// Function used to gather info from eSupport and SU by MTM
        /// </summary>
        /// <param name="MTM">The type to pull data from</param>
        /// <returns>The List of DGRow objects to parse</returns>
        private List<DGRow> silentRun(string MTM, string operatingSystem)
        {
            string type = MTM;
            string os = operatingSystem;
            string url = "https://download.lenovo.com/catalog/" + type + "_" + os + ".xml";

            List<DownloadItem> eSupport = geteSupportInfoByType(type, os);
            List<DownloadItem> su = parseSystemUpdate(url);
            downloadLUC();
            List<DGRow> rows = new List<DGRow>();
            log.Info("Matching up the data");
            foreach (DownloadItem d in eSupport)
            {
                var matches = su.Where(p => p.ID.Equals(d.ID));
                if (matches.Count() > 0)
                {
                    foreach (DownloadItem match in matches)
                    {
                        DGRow row = new DGRow(d, match, type);
                        //MessageBox.Show(row.package);
                        rows.Add(row);
                    }//end foreach
                }//end if
                else
                {
                    DGRow row = new DGRow(d, null, type);
                    //MessageBox.Show(row.package);
                    rows.Add(row);
                }//end else
            }//end foreach

            foreach (DownloadItem s in su)
            {
                var matches = eSupport.Where(p => p.ID.Equals(s.ID));
                if (matches.Count() == 0)
                {
                    DGRow row = new DGRow(null, s, type);
                    //MessageBox.Show(row.package);
                    rows.Add(row);
                }//end if
            }//end foreach
            return rows;
        }//end silentRun

        /// <summary>
        /// Downloads the LUC cab file and extracts it
        /// </summary>
        private void downloadLUC()
        {
            string lucFolder = Path.Combine(baseFolder, Properties.Settings.Default.LucFolder);
            string lucCab = Properties.Settings.Default.LucCab;
            try
            {
                Directory.CreateDirectory(lucFolder);
            }//end try
            catch (Exception e) { }
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; //TLS 1.2
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile("https://download.lenovo.com/luc/LenovoUpdatesCatalog2.cab", Path.Combine(lucFolder, lucCab));
            }//end using
            var destDir = lucFolder;
            EnsureDirectoryExists(destDir);
            var cabToUnpack = new CabInfo(Path.Combine(lucFolder, lucCab));
            cabToUnpack.Unpack(destDir);
        }//end downloadLUC

        /// <summary>
        /// Checks to see if the directory exists
        /// </summary>
        /// <param name="dir"></param>
        private static void EnsureDirectoryExists(string dir)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }//end if
        }//end EnsureDirectoryExits

        /// <summary>
        /// Download the top catalog, sub catalogs, and exes if the CRC check is enabled
        /// </summary>
        /// <param name="url">The link to the master catalog for the type</param>
        /// <returns>A list of the DownloadItem objects representing the SU catalog for the model type</returns>
        private List<DownloadItem> parseSystemUpdate(string url)
        {
            string fileName = url.Substring(url.LastIndexOf("/") + 1);
            string folderName = fileName.Substring(0, fileName.Length - 4);
            log.Info("Creating the directories for System Update information");
            try
            {
                Directory.CreateDirectory(Path.Combine(baseFolder, Properties.Settings.Default.ExeFolder));
                Directory.CreateDirectory(baseFolder + "\\xmls");
                Directory.CreateDirectory(baseFolder + "\\xmls\\" + fileName.Substring(0, fileName.Length - 4));
                //Directory.CreateDirectory(baseFolder + "\\xmls\\" + fileName.Substring(0, fileName.Length - 4) + "\\exes");
            }//end try
            catch (Exception e) { }

            try
            {
                if (!File.Exists(baseFolder + "\\xmls\\" + folderName + "\\" + fileName))
                {
                    using (var webClient = new WebClient())
                    {
                        webClient.DownloadFile(url, baseFolder + "\\xmls\\" + folderName + "\\" + fileName);
                    }//end using
                }
                else
                {
                    using (var webClient = new WebClient())
                    {
                        webClient.DownloadFile(url, baseFolder + "\\xmls\\" + folderName + "\\" + (fileName).Replace(".", "_desc."));
                    }//end using
                    /*XmlDocument desc = new XmlDocument();
                    desc.Load(baseFolder + "\\xmls\\" + folderName + "\\" + (fileName).Replace(".", "_desc."));
                    string descHash = desc.SelectSingleNode("/catalog/checksum").InnerText;
                    using (var fileStream = new FileStream(baseFolder + "\\xmls\\" + folderName + "\\" + fileName, FileMode.OpenOrCreate, FileAccess.Read))
                    {
                        string str2 = GetChecksumBuffered(fileStream, descHash.Length);
                    }//end using*/
                }
                List<DownloadItem> su = new List<DownloadItem>();
                XmlDocument doc = new XmlDocument();
                doc.Load(baseFolder + "\\xmls\\" + folderName + "\\" + fileName);
                int count = doc.SelectNodes("/packages/package").Count;
                foreach (XmlNode node in doc.SelectNodes("/packages/package"))
                {
                    DownloadItem di = parseXML2(node["location"].InnerText, node["checksum"].InnerText, folderName);
                    if (di != null)
                    {
                        di.Category = node["category"].InnerText;

                        su.Add(di);
                    }
                    suWorker.ReportProgress(50 / count);
                    //toolStripProgressBar1.Value += 50 / count;
                }//end foreach
                return su;
            }
            catch (WebException e)
            {
                Console.Out.WriteLine("Catalog not found!");
                return new List<DownloadItem>();
            }
        }//end parseSystemUpdate

        /// <summary>
        /// Helper function to parse the sub catalogs
        /// </summary>
        /// <param name="location">Link to the sub catalog</param>
        /// <param name="hash">CRC of the catalog</param>
        /// <param name="fName">Folder name to place the stuff in</param>
        /// <returns>A DownloadItem representing the sub catalog</returns>
        private DownloadItem parseXML2(string location, string hash, string fName)
        {
            log.Info("Parsing " + location);
            DownloadItem di = new DownloadItem();
            try
            {
                string xml2 = location;
                string xml2Filename = xml2.Substring(xml2.LastIndexOf("/") + 1);
                if (!File.Exists(baseFolder + "\\xmls\\" + fName + "\\" + xml2Filename))
                {
                    using (var webClient = new WebClient())
                    {
                        webClient.DownloadFile(xml2, baseFolder + "\\xmls\\" + fName + "\\" + xml2Filename);
                    }//end using
                }//end if
                XmlDocument doc2 = new XmlDocument();
                doc2.Load(baseFolder + "\\xmls\\" + fName + "\\" + xml2Filename);

                //Read the parts of the xml2
                di.ID = doc2.SelectSingleNode("/Package/Files/Installer/File/Name").InnerText.ToLower();
                di.Name = doc2.SelectSingleNode("/Package/Title/Desc").InnerText;
                if (excludePackages != null && excludePackages.Any(s => di.Name.Trim().StartsWith(s)))
                    return null;
                di.ReleaseDate = doc2.SelectSingleNode("/Package/ReleaseDate").InnerText;
                di.Version = doc2.SelectSingleNode("/Package").Attributes["version"].Value;
                di.PageURL = xml2;
                di.GivenXMLHash = hash;

                di.GivenEXEHash = doc2.SelectSingleNode("/Package/Files/Installer/File/CRC").InnerText;
                di.ExeURL = xml2.Substring(0, xml2.LastIndexOf("/") + 1) + doc2.SelectSingleNode("/Package/Files/Installer/File/Name").InnerText;

                //XML CRC Check
                if (!preventCRCXML)
                {
                    using (var fileStream = new FileStream(baseFolder + "\\xmls\\" + fName + "\\" + xml2Filename, FileMode.OpenOrCreate, FileAccess.Read))
                    {
                        string str2 = GetChecksumBuffered(fileStream, di.GivenXMLHash.Length);
                        di.ComputedXMLHash = str2;
                    }//end using
                }//end if

                //EXE CRC Check
                if (!preventCRCEXE)
                {
                    if (!File.Exists(baseFolder + "\\exes\\" + di.ID + ".exe"))
                    {
                        using (var wclient = new WebClient())
                        {
                            wclient.DownloadFile(di.ExeURL, baseFolder + "\\exes\\" + di.ID + ".exe");
                        }//end using
                    }//end if
                    else
                    {
                        DateTime date = File.GetCreationTime(baseFolder + "\\exes\\" + di.ID + ".exe");
                        if (date.Date != DateTime.Now.Date)
                        {
                            File.Delete(baseFolder + "\\exes\\" + di.ID + ".exe");
                            using (var wclient = new WebClient())
                            {
                                wclient.DownloadFile(di.ExeURL, baseFolder + "\\exes\\" + di.ID + ".exe");
                            }//end using
                        }//end if
                    }//end else

                    using (var fileStream = new FileStream(baseFolder + "\\exes\\" + di.ID + ".exe", FileMode.OpenOrCreate, FileAccess.Read))
                    {
                        string str2 = GetChecksumBuffered(fileStream, di.GivenEXEHash.Length);
                        di.ComputedEXEHash = str2;
                    }//end using FileStream
                }//end if
            }//end try
            catch (WebException e)
            {
                Console.Out.WriteLine("Sub catalog not found!\n" + location);
                log.Error("Sub catalog not found! - " + location);
                return null;
            }//end catch
            catch (Exception e)
            {
                Console.Out.WriteLine("Unexpected issue on: " + location);
                log.Error("Unexpected issue on: " + location);
                return null;
            }//end general catch
            return di;
        }//end parseXML2

        /// <summary>
        /// Parse eSupport for all the relevant info to the model
        /// </summary>
        /// <returns>A list of the DownloadItem objects representing the eSupport for the model type</returns>
        public List<DownloadItem> geteSupportInfo()
        {
            string mtm = modelInfo.First(x => x.getName().Equals(cb_model.Text)).getMTM();
            return geteSupportInfoByType(mtm, cb_os.Text);
        }//end geteSupportInfo

        /// <summary>
        /// Gets the eSupport info silently based on the model type and operating system
        /// </summary>
        /// <param name="type">The type to use to get the parent id</param>
        /// <param name="operatingSystem">The operating system to target</param>
        /// <returns>A list of the DownloadItem objects representing the eSupport for the model type</returns>
        public List<DownloadItem> geteSupportInfoByType(string type, string operatingSystem)
        {
            string responseText = "";
            WebClient webClient = new WebClient();
            string parentID = modelInfo.First(x => x.getMTM().Equals(type)).getParentID();
            Console.WriteLine(parentID);
            JArray drivers = ESupportAPI.GetCatalogForModelByParentID(parentID);
            if (drivers.Count == 0)
                throw new Exception("There are no drivers listed for this model (" + parentID + ")!");
            List<DownloadItem> jr = new List<DownloadItem>();
            string selectedOS = getESupportOS(operatingSystem);
            /*string url = "https://pcsupport.lenovo.com/us/en/products/" + parentID.ToLower() + "/downloads"; //grabs the model user selects
                //ServicePointManager.SecurityProtocol = (SecurityProtocolType)768; //TLS 1.2
                responseText = processLink(url);

            eSupportModelInformation mi;
            byte[] base64 = DecompressBytes(responseText);
            string json = Encoding.UTF8.GetString(base64);

            mi = JsonConvert.DeserializeObject<eSupportModelInformation>(json);
            mi.sortDrivers();

            string output = JsonConvert.SerializeObject(mi);
            var currentJSON = JObject.Parse(output);*/

            //eSupport links
            List<string> dsLinks = new List<string>();
            foreach (JToken driver in drivers)
            {
                string dsID = (string)driver["ID"];
                dsLinks.Add(dsID);
            }//end foreach

            foreach (string ds in dsLinks)
            {
                var currentJSON = ESupportAPI.GetAllDataFromDS(ds);
                //grabs json object to display for user based on model selection
                foreach (var os in currentJSON["OperatingSystems"])
                {
                    if (os.ToString().Equals(selectedOS))
                    {
                        string parentTitle = (string)currentJSON["Title"];
                        foreach (var file in currentJSON["Files"])
                        {
                            foreach (var opSys in file["OperatingSystems"])
                            {
                                if (os.ToString().Equals(selectedOS))
                                {
                                    //creates download obj to hold the each machine list specific to machine ID

                                    // objList.ID = (string)obj["DocId"];
                                    //make sure i get all exes
                                    DownloadItem objList = new DownloadItem();
                                    string fileUrl = (string)file["URL"];
                                    if (parentTitle.Contains('-'))
                                        parentTitle = parentTitle.Substring(0, parentTitle.IndexOf('-') - 1);
                                    if (fileUrl.EndsWith(".exe") || fileUrl.EndsWith(".zip"))
                                    {
                                        string name = (string)file["Title"];
                                        if (parentTitle.EndsWith(")"))
                                        {
                                            string winVer = " " + parentTitle.Substring(parentTitle.LastIndexOf('('));
                                            if (winVer.Equals(" (64-bit)") || winVer.Equals(" (32-bit)"))
                                                winVer = "";
                                            if (!name.EndsWith(")"))
                                                name += winVer;
                                        }
                                        objList.Name = name;

                                        if (excludePackages != null && excludePackages.Any(s => objList.Name.Trim().StartsWith(s)))
                                            continue;


                                        objList.PageURL = "https://support.lenovo.com/downloads/" + ds;
                                        objList.ExeURL = fileUrl;
                                        objList.ID = fileUrl.Substring(fileUrl.LastIndexOf("/") + 1).ToLower();
                                        //objList.Name = (string)file["Name"];
                                        objList.Version = ((string)file["Version"]).Trim();
                                        objList.GivenEXEHash = (string)file["SHA256"];
                                        foreach (var cat in currentJSON["Categories"])
                                        {
                                            objList.Category = (string)cat;
                                        }//end foreach

                                        //MessageBox.Show(UnixTimeStampToDateTime((double)obj["Date"]["Unix"]).ToString());
                                        objList.ReleaseDate = (string)currentJSON["Updated"];


                                        jr.Add(objList);

                                    }//end if
                                }//end if
                            }//end foreach inner operating system
                        }//end foreach files
                    }//end if
                }//end foreach outer operating system
            }//end foreach link
            eSupportWorker.ReportProgress(50);
            return jr;
        }//end geteSupportInfoByType

        /*public byte[] DecompressBytes(string text)
        {
            byte[] encoded = Convert.FromBase64String(text);
            if (encoded == null || encoded.Length == 0)
            {
                MessageBox.Show(text);
                throw new ArgumentException("encoded data is null or size is 0");
            }

            byte[] decoded;

            // estimate, 10 times the compressed size
            byte[] buffer = new byte[encoded.Length * 10];
            int decodedsize = LZ4Codec.Decode(encoded, 0, encoded.Length, buffer, 0, buffer.Length, false);

            if (decodedsize > 0)
            {
                decoded = new byte[decodedsize];
                Array.Copy(buffer, decoded, decodedsize);
            }
            else
            {
                throw new InvalidOperationException("Failed to decode");
            }

            return decoded;
        }*/

        /* **********************************************************************************************************************************************
         * **********************************************************************************************************************************************
         * ********************************************************** HELPER FUNCTIONS ******************************************************************
         * **********************************************************************************************************************************************
         * **********************************************************************************************************************************************/


        /// <summary>
        /// Gets the CRC based on the on the size and filestream
        /// </summary>
        /// <param name="stream">The stream pointing to the file</param>
        /// <param name="size">Length of the given hash</param>
        /// <returns>The computed CRC</returns>
        private string GetChecksumBuffered(Stream stream, int size)
        {
            //SHA256
            if (size == 64)
            {
                using (var bufferedStream = new BufferedStream(stream, 1024 * 32))
                {
                    var sha = new SHA256Managed();
                    byte[] checksum = sha.ComputeHash(bufferedStream);
                    return BitConverter.ToString(checksum).Replace("-", String.Empty);
                }//end using
            }//end if
            //end SHA1
            else
            {
                using (var bufferedStream = new BufferedStream(stream, 1024 * 32))
                {
                    var sha = new SHA1Managed();
                    byte[] checksum = sha.ComputeHash(bufferedStream);
                    return BitConverter.ToString(checksum).Replace("-", String.Empty);
                }//end using
            }//end else
        }//end GetChecksumBuffered

        /// <summary>
        /// Converts the short name to the OS string eSupport uses
        /// </summary>
        /// <param name="os">Short name of OS</param>
        /// <returns>New string for eSupport</returns>
        private string getESupportOS(string os)
        {
            if (os.Equals("Win7"))
                return "Windows 7 (64-bit)";
            else if (os.Equals("Win10"))
                return "Windows 10 (64-bit)";
            else if (os.Equals("Win11"))
                return "Windows 11 (64-bit)";
            return "";
        }//end getESupportOS

        /// <summary>
        /// Gets a subset of the models containing the family name
        /// </summary>
        /// <param name="family"></param>
        /// <returns></returns>
        private IList<ModelInformation> getShortName(string family)
        {
            family = family.ToLower();
            IList<ModelInformation> mi = new List<ModelInformation>();
            foreach (ModelInformation m in modelInfo)
            {
                if (m.getName().ToLower().Contains(family))
                    mi.Add(m);
            }//end foreach
            return mi;
        }//end getShortName

        /// <summary>
        /// Converts the list of DGRows to a data table
        /// </summary>
        /// <param name="list">the List of DGRow</param>
        private void setupDataGrid(List<DGRow> list)
        {
            /*
             * This is for the LUC catalog bit
             * 
            XmlDocument doc = new XmlDocument();
            doc.Load(baseFolder + "\\luc\\LenovoUpdatesCatalog2.xml");
            XmlNamespaceManager manager = new XmlNamespaceManager(doc.NameTable);
            manager.AddNamespace("smc", "http://schemas.microsoft.com/sms/2005/04/CorporatePublishing/SystemsManagementCatalog.xsd");
            manager.AddNamespace("bar", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/BaseApplicabilityRules.xsd");
            manager.AddNamespace("bt", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/BaseTypes.xsd");
            manager.AddNamespace("cmd", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/Installers/CommandLineInstallation.xsd");
            manager.AddNamespace("lar", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/LogicalApplicabilityRules.xsd");
            manager.AddNamespace("msi", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/Installers/MsiInstallation.xsd");
            manager.AddNamespace("msiar", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/MsiApplicabilityRules.xsd");
            manager.AddNamespace("msp", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/Installers/MspInstallation.xsd");
            manager.AddNamespace("sdp", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/SoftwareDistributionPackage.xsd");
            manager.AddNamespace("uei", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/Installers/UpdateExeInstallation.xsd");
            manager.AddNamespace("usp", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/UpdateServicesPackage.xsd");
            manager.AddNamespace("drv", "http://schemas.microsoft.com/wsus/2005/04/CorporatePublishing/Installers/WindowsDriver.xsd");
            manager.AddNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance");

            foreach (DGRow row in list)
            {
                try
                {
                    string xpath = string.Format("/smc:SystemsManagementCatalog/smc:SoftwareDistributionPackage/sdp:InstallableItem/sdp:OriginFile[@FileName='{0}']/../..", (row.package));
                    XmlNode node = doc.SelectSingleNode(xpath, manager);
                    if (node != null)
                    {
                        row.lucVersion = "View XML";
                        row.lucXML = node.OuterXml;
                    }//end if
                    else
                    {
                        row.lucVersion = "";
                        row.lucXML = "";
                    }//end else
                }catch(XPathException e)
                {
                    MessageBox.Show(e.Message);
                    row.lucVersion = "";
                }//end catch
            }//end foreach
            */

            ListtoDataTable ltod = new ListtoDataTable();
            DataTable dt = ltod.ToDataTable(list).DefaultView.ToTable(true);
            dt.Columns["Issues"].SetOrdinal(0);

            //Remove the columns that are to be excluded
            foreach (string col in excludeColumns)
            {
                // Console.Out.WriteLine("Removing column " + col);
                dt.Columns.Remove(col);
            }//end foreach

            if (mode == SilentOutputMode.Warning)
            {
                for (int i = dt.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr = dt.Rows[i];

                    if (dr["Issues"] == DBNull.Value)
                    {
                        dr.Delete();
                    }//end if
                }//end for
            }//end if
            if (hideIssues.Count > 0)
            {
                for (int i = dt.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr = dt.Rows[i];

                    if (dr["Issues"] == DBNull.Value)
                        continue;
                    string issues = (string)dr["Issues"];
                    foreach (string hide in hideIssues)
                    {
                        issues = issues.Replace(hide, " ");
                    }//end foreach

                    if (string.IsNullOrWhiteSpace(issues))
                        dr.Delete();
                    else
                        dr["Issues"] = issues;
                }//end for
            }//end if

            matchPartitialPackages(dt);

            dt.AcceptChanges();
            dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns["Name"], ListSortDirection.Ascending);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string eSE = (string)row.Cells["eSupportExeLink"].Value;
                string suE = (string)row.Cells["suExeLink"].Value;
                var issueCell = row.Cells["Issues"];
                row.Cells["eSupportVersion"].ToolTipText = eSE;
                row.Cells["suVersion"].ToolTipText = suE;
                StringBuilder toolTip = new StringBuilder();
                if (issueCell.Value.ToString().Contains("1"))
                    toolTip.AppendLine("Product version mismatch");
                if (issueCell.Value.ToString().Contains("2"))
                    toolTip.AppendLine("Exe files at different locations");
                if (issueCell.Value.ToString().Contains("3"))
                    toolTip.AppendLine("Hash algoritm mismatch");
                if (issueCell.Value.ToString().Contains("4"))
                    toolTip.AppendLine("Hash value mismatch");
                if (issueCell.Value.ToString().Contains("5"))
                    toolTip.AppendLine("CRC exe value mismatch");
                if (issueCell.Value.ToString().Contains("6"))
                    toolTip.AppendLine("CRC xml vaue mismatch");
                if (issueCell.Value.ToString().Contains("7"))
                    toolTip.AppendLine("Package not availible on eSupport");
                if (issueCell.Value.ToString().Contains("8"))
                    toolTip.AppendLine("Package not availible on System Update");
                issueCell.ToolTipText = toolTip.ToString();
            }//end foreach
        }//end setupDataGrid

        /// <summary>
        /// Matches the potentially different names between eSupport and SystemUpdate
        /// </summary>
        /// <param name="dt">The data table</param>
        public void matchPartitialPackages(DataTable dt)
        {
            List<DataRow> notOnESupport = new List<DataRow>();
            List<DataRow> notOnSU = new List<DataRow>();

            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = dt.Rows[i];

                if (dr["Issues"] == DBNull.Value)
                    continue;
                string issues = (string)dr["Issues"];
                if (issues.Contains("7"))
                {
                    notOnESupport.Add(dr);
                }//end if
                if (issues.Contains("8"))
                {
                    notOnSU.Add(dr);
                }//end if
            }//end for

            //MessageBox.Show("" + notOnESupport.Count);
            // MessageBox.Show("" + notOnSU.Count);

            foreach (DataRow d in notOnESupport)
            {
                foreach (DataRow e in notOnSU)
                {
                    string ePackage = (string)d["package"];
                    string sPackage = (string)e["package"];
                    int distance = LevenshteinDistance.Compute(ePackage, sPackage);
                    if (distance < 3)
                    { }
                    //MessageBox.Show((string)d["package"] + " " + (string)e["package"] + " " + distance);
                }//end foreach not su
            }//end foreach not esupport
        }//end matchPartialPackages

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xmlText"></param>
        public void LoadXMLtoBox(string xmlText)
        {
            XMLViewer view = new XMLViewer();
            view.addXML(xmlText);
            view.Show();
        }//end LoadXMLtoBox

        /// <summary>
        /// Parses the JSON of all models into a list
        /// </summary>
        /// <returns>List of ModelInformation</returns>
        public static List<ModelInformation> GetAllModels()
        {
            Dictionary<string, string> replacements = new Dictionary<string, string> { { "THINKPAD", "ThinkPad" },
                                                                                       { "THINKCENTRE", "ThinkCentre" },
                                                                                       { "THINKSTATION", "ThinkStation" },
                                                                                       { "TYPE", "Type" },
                                                                                       { "CARBON", "Carbon" },
                                                                                       { "YOGA", "Yoga" },
                                                                                       { "HYBRID", "Hybrid" },
                                                                                       { "TABLET", "Tablet" },
                                                                                       { "TWIST", "Twist" },
                                                                                       { "GEN", "Gen" },
                                                                                       { "1ST", "1st" },
                                                                                       { "2ND", "2nd" },
                                                                                       { "3RD", "3rd" },
                                                                                       { "4TH", "4th" },
                                                                                       { "11E", "11e" }};
            List<ModelInformation> mi = new List<ModelInformation>();
            List<string> thinkProducts = new List<string> { "THINKPAD", "THINKCENTRE", "THINKSTATION", "ideapad" };
            /*string urlToProductInfo = "https://pcsupport.lenovo.com/services/us/en/ContentService/GetProducts?productId=";
            WebClient webClient = new WebClient();
            string json1 = webClient.DownloadString(urlToProductInfo);
            var entities = JsonConvert.DeserializeObject<List<JSONModelEntity>>(json1);*/
            string json1 = ESupportAPI.GetModelInformation();
            var entities = JsonConvert.DeserializeObject<List<ModelAPI>>(json1);
            foreach (var entity in entities)
            {
                if (thinkProducts.Any(s => entity.ID.Contains(s)) || entity.Name.Contains("(ideapad)"))
                {
                    string[] parts = entity.ID.Split('/');
                    if (parts.Last().Length == 4)
                    {
                        string type = parts.Last();
                        string name = parts[parts.Length - 2].Replace('-', ' ');
                        if (name.Contains("YOGA") && (!name.Contains("THINKPAD") && !name.Contains("IDEAPAD")))
                            name = "IdeaPad " + name;
                        var newstr = replacements.Aggregate(name, (current, value) =>
                                        current.Replace(value.Key, value.Value));
                        string url = entity.ID;
                        mi.Add(new ModelInformation(newstr, type, url));
                        // this.comboBox1.Items.Add((entity.Value));
                    }//end if
                }//end if
            }//end foreach
            mi.Sort();
            return mi;
        }//end getAllModels

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddMilliseconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        /* **********************************************************************************************************************************************
         * **********************************************************************************************************************************************
         * ********************************************************** EVENT LISTENERS *******************************************************************
         * **********************************************************************************************************************************************
         * **********************************************************************************************************************************************/

        /// <summary>
        /// Validation function to enable the submit button
        /// </summary>
        /// <returns></returns>
        private bool generalValidate()
        {
            if (cb_family.SelectedIndex != -1 && cb_model.SelectedIndex != -1 && cb_os.SelectedIndex != -1)
            {
                linkLabel1.Links.Clear();
                string type = modelInfo.First(x => x.getName().Equals(cb_model.Text)).getMTM();
                string os = cb_os.Text;
                string url = "https://download.lenovo.com/catalog/" + type + "_" + os + ".xml";
                LinkLabel.Link link = new LinkLabel.Link();
                link.LinkData = url;
                linkLabel1.Links.Add(link);
                linkLabel1.Visible = true;
                linkLabel1.Text = url;
                return true;
            }//end if
            else
            {
                linkLabel1.Visible = false;
                return false;
            }//end else
        }//end generalValidate

        /// <summary>
        /// Puts the models in the combobox based on the family
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_family_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_model.Items.Clear();
            IList<ModelInformation> models = getShortName(cb_family.Text);
            if (models != null)
            {
                foreach (ModelInformation m in models.Distinct(new ModelComparer()).ToList())
                {
                    cb_model.Items.Add(m.getName());
                }//end foreach
            }//end if
            button_submit.Enabled = generalValidate();
        }//end cb_family_SelectedIndexChanged

        /// <summary>
        /// Listener on the os combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_os_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_submit.Enabled = generalValidate();
        }//end cb_os_SelectedIndexChanged

        /// <summary>
        /// Listener on the model combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_submit.Enabled = generalValidate();
        }//end cb_model_SelectedIndexChanged

        /// <summary>
        /// Toggles CRC check on xml files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            preventCRCXML = !preventCRCXML;
        }//end checkBox1_CheckedChanged

        /// <summary>
        /// Listener on the excel export button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            excelWorker.RunWorkerAsync(cb_model.Text + "_" + cb_os.Text);
        }//end button1_Click

        /// <summary>
        /// Toggles the hash columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox2.Checked;
            dataGridView1.Columns["eSupportHash"].Visible = check;
            dataGridView1.Columns["suGivenEXEHash"].Visible = check;
            dataGridView1.Columns["suComputedEXEHash"].Visible = check;
            dataGridView1.Columns["suGivenXMLHash"].Visible = check;
            dataGridView1.Columns["suComputedXMLHash"].Visible = check;
        }//end checkBox2_CheckedChanged

        /// <summary>
        /// Listener on the datagrid cells
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].HeaderText.Equals("eSupportVersion"))
                {
                    System.Diagnostics.Process.Start((string)dataGridView1.Rows[row].Cells["eSupportDSLink"].Value);
                }//end if
                else if (dataGridView1.Columns[e.ColumnIndex].HeaderText.Equals("suVersion"))
                {
                    System.Diagnostics.Process.Start((string)dataGridView1.Rows[row].Cells["suCatalogLink"].Value);
                }//end else if
                else if (dataGridView1.Columns[e.ColumnIndex].HeaderText.Equals("lucVersion"))
                {
                    LoadXMLtoBox((string)dataGridView1.Rows[row].Cells["lucXML"].Value);
                }//end else if
            }//end if
        }//end dataGridView1_CellContentClick

        /// <summary>
        /// Listener on the column headers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == newSortColumn)
            {
                if (newColumnDirection == ListSortDirection.Ascending)
                    newColumnDirection = ListSortDirection.Descending;
                else
                    newColumnDirection = ListSortDirection.Ascending;
            }//end if

            newSortColumn = e.ColumnIndex;

            switch (newColumnDirection)
            {
                case ListSortDirection.Ascending:
                    dataGridView1.Sort(dataGridView1.Columns[newSortColumn], ListSortDirection.Ascending);
                    break;
                case ListSortDirection.Descending:
                    dataGridView1.Sort(dataGridView1.Columns[newSortColumn], ListSortDirection.Descending);
                    break;
            }//end switch

            //After sorting we need to reapply all the tooltips
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string eSE = (string)row.Cells["eSupportExeLink"].Value;
                string suE = (string)row.Cells["suExeLink"].Value;
                var issueCell = row.Cells["Issues"];
                row.Cells["eSupportVersion"].ToolTipText = eSE;
                row.Cells["suVersion"].ToolTipText = suE;
                StringBuilder toolTip = new StringBuilder();
                if (issueCell.Value.ToString().Contains("1"))
                    toolTip.AppendLine("Product version mismatch");
                if (issueCell.Value.ToString().Contains("2"))
                    toolTip.AppendLine("Exe files at different locations");
                if (issueCell.Value.ToString().Contains("3"))
                    toolTip.AppendLine("Hash algoritm mismatch");
                if (issueCell.Value.ToString().Contains("4"))
                    toolTip.AppendLine("Hash value mismatch");
                if (issueCell.Value.ToString().Contains("5"))
                    toolTip.AppendLine("CRC exe value mismatch");
                if (issueCell.Value.ToString().Contains("6"))
                    toolTip.AppendLine("CRC xml vaue mismatch");
                if (issueCell.Value.ToString().Contains("7"))
                    toolTip.AppendLine("Package not availible on eSupport");
                if (issueCell.Value.ToString().Contains("8"))
                    toolTip.AppendLine("Package not availible on System Update");
                issueCell.ToolTipText = toolTip.ToString();
            }//end foreach
        }//end dataGridView1_ColumnHeaderMouseClick

        /// <summary>
        /// Listener on the filter box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", comboBox1.Text, textBox1.Text);
        }//end textBox1_TextChanged

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
                textBox1.Enabled = true;
        }//end comboBox1_SelectedIndexChanged

        /// <summary>
        /// Do all the processing. Probably should split this into a background worker.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_submit_Click(object sender, EventArgs e)
        {
            button_submit.Enabled = false;
            string type = modelInfo.First(x => x.getName().Equals(cb_model.Text)).getMTM();

            string os = cb_os.Text;
            string url = "https://download.lenovo.com/catalog/" + type + "_" + os + ".xml";

            suWorker.RunWorkerAsync(url);

            eSupportWorker.RunWorkerAsync(new string[] { type, os });
            toolStripStatusLabel1.Text = "Parsing eSupport and System Update...";

            downloadLUC();

            while (suWorker.IsBusy || eSupportWorker.IsBusy)
            {
                Application.DoEvents();
            }

            toolStripStatusLabel1.Text = "Comparing the data...";

            List<DGRow> rows = new List<DGRow>();
            foreach (DownloadItem d in eSupport)
            {
                var matches = su.Where(p => p.ID.Equals(d.ID));
                if (matches.Count() > 0)
                {
                    foreach (DownloadItem match in matches)
                    {
                        DGRow row = new DGRow(d, match, type);
                        //MessageBox.Show(row.package);
                        rows.Add(row);
                    }//end foreach
                }//end if

                else
                {
                    DGRow row = new DGRow(d, null, type);
                    //MessageBox.Show(row.package);
                    rows.Add(row);
                }//end else
            }//end foreach

            foreach (DownloadItem s in su)
            {
                var matches = eSupport.Where(p => p.ID.Equals(s.ID));
                if (matches.Count() == 0)
                {
                    DGRow row = new DGRow(null, s, type);
                    //MessageBox.Show(row.package);
                    rows.Add(row);
                }//end if
            }//end foreach

            setupDataGrid(rows);
            button_submit.Enabled = true;
            groupBox2.Enabled = true;
            toolStripProgressBar1.Value = 0;
            toolStripStatusLabel1.Text = "Done!";
        }//end button_submit_Click

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            preventCRCEXE = !preventCRCEXE;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void excelWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string modelOS = e.Argument as string;
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = false;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs(baseFolder + "\\" + modelOS + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void excelWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Application.UseWaitCursor = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eSupportWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] args = e.Argument as string[];
            eSupport = geteSupportInfoByType(args[0], args[1]);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eSupportWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!suWorker.IsBusy)
                toolStripProgressBar1.Value = 100;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string url = e.Argument as string;
            su = parseSystemUpdate(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value += e.ProgressPercentage;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!eSupportWorker.IsBusy)
                toolStripProgressBar1.Value = 100;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eSupportWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value += e.ProgressPercentage;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "LEN(eSupportVersion) <> 0 AND LEN(suVersion) <> 0";
            }
            else if (radioButton2.Checked)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "(LEN(eSupportVersion) <> 0 AND LEN(suVersion) = 0) OR (LEN(eSupportVersion) = 0 AND LEN(suVersion) <> 0)";
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url;
            if (e.Link.LinkData != null)
                url = e.Link.LinkData.ToString();
            else
                url = linkLabel1.Text.Substring(e.Link.Start, e.Link.Length);

            if (!url.Contains("://"))
                url = "https://" + url;

            var si = new ProcessStartInfo(url);
            Process.Start(si);
            linkLabel1.LinkVisited = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                excludePackages.Clear();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
                excludeColumns.Clear();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                textBox4.Enabled = true;
            }
            else
            {
                textBox4.Enabled = false;
                hideIssues.Clear();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            mode = SilentOutputMode.Warning;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(baseFolder + "\\xmls\\");
            if (di.Exists)
            {
                foreach (FileInfo file in di.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.EnumerateDirectories())
                {
                    dir.Delete(true);
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }//end form1

    /* **********************************************************************************************************************************************
     * **********************************************************************************************************************************************
     * *********************************************************** HELPER CLASSES *******************************************************************
     * **********************************************************************************************************************************************
     * **********************************************************************************************************************************************/

    /// <summary>
    /// Class to represent the rows in the datagrid
    /// </summary>


    /// <summary>
    /// 
    /// </summary>
    public class ListtoDataTable
    {
        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties by using reflection   
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names  
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {

                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class My_DataTable_Extensions
    {
        /// <summary>
        /// Export DataTable to Excel file
        /// </summary>
        /// <param name="DataTable">Source DataTable</param>
        /// <param name="ExcelFilePath">Path to result file name</param>
        public static void ExportToExcel(this System.Data.DataTable DataTable, string ExcelFilePath = null)
        {
            try
            {
                int ColumnsCount;

                if (DataTable == null || (ColumnsCount = DataTable.Columns.Count) == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbooks.Add();

                // single worksheet
                Microsoft.Office.Interop.Excel._Worksheet Worksheet = Excel.ActiveSheet;

                object[] Header = new object[ColumnsCount];

                // column headings               
                for (int i = 0; i < ColumnsCount; i++)
                    Header[i] = DataTable.Columns[i].ColumnName;

                Microsoft.Office.Interop.Excel.Range HeaderRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, ColumnsCount]));
                HeaderRange.Value = Header;
                HeaderRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                HeaderRange.Font.Bold = true;

                // DataCells
                int RowsCount = DataTable.Rows.Count;
                object[,] Cells = new object[RowsCount, ColumnsCount];

                for (int j = 0; j < RowsCount; j++)
                    for (int i = 0; i < ColumnsCount; i++)
                        Cells[j, i] = DataTable.Rows[j][i];

                Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[2, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 1, ColumnsCount])).Value = Cells;
                Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[2, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 1, ColumnsCount])).Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                Worksheet.Columns.AutoFit();
                /*Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 1, ColumnsCount])).AddComment("1 = Product version mismatch" +
                    "\n2 = Exe files at different locations" +
                    "\n3 = Hash algoritm mismatch" +
                    "\n4 = Hash value mismatch" +
                    "\n5 = CRC exe value mismatch" +
                    "\n6 = CRC xml vaue mismatch" +
                    "\n7 = Package not availible on eSupport" +
                    "\n8 = Package not availible on System Update");*/


                if (ExcelFilePath != null && ExcelFilePath != "")
                {
                    try
                    {
                        Worksheet.SaveAs(ExcelFilePath);
                        Excel.Quit();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                            + ex.Message);
                    }
                }
                else    // no filepath is given
                {
                    Excel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }
    }

    /// <summary>
    /// Contains approximate string matching
    /// </summary>
    static class LevenshteinDistance
    {
        /// <summary>
        /// Compute the distance between two strings.
        /// </summary>
        public static int Compute(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }

            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }
    }

    /* **********************************************************************************************************************************************
     * **********************************************************************************************************************************************
     * *********************************************** CLASSES FOR JSON TO BE PARSED INTO ***********************************************************
     * **********************************************************************************************************************************************
     * **********************************************************************************************************************************************/
    public class Model
    {
        public string name { get; set; }
        public string[] types { get; set; }
    }

    public class JSONData
    {
        public IList<Model> TP { get; set; }
        public IList<Model> TC { get; set; }
        public IList<Model> TS { get; set; }
    }

    public class PackageInfo
    {
        public string name { get; set; }
        public string version { get; set; }
        public string id { get; set; }
        public string releaseDate { get; set; }
    }

    public class DownloadItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Category { get; set; }
        public string PageURL { get; set; }
        public string GivenEXEHash { get; set; }
        public string ComputedEXEHash { get; set; }
        public string GivenXMLHash { get; set; }
        public string ComputedXMLHash { get; set; }
        public string ExeURL { get; set; }
        public string ReleaseDate { get; set; }

    }
    class eSupportModelInformation
    {
        public string ProductId { get; set; }
        public eSupportDriverInfo[] DownloadItems { get; set; }

        public void sortDrivers()
        {
            Array.Sort(DownloadItems, (a, b) => String.Compare(a.DocId, b.DocId));
        }
    }

    class eSupportDriverInfo
    {
        public eSupportDriverCategory[] Categories { get; set; }
        public string[] OperatingSystemKeys { get; set; }
        public string DocId { get; set; }
        public string Title { get; set; }
        public eSupportDriverFile[] Files { get; set; }
        public eSupportDriverDate Date { get; set; }
    }

    class eSupportDriverCategory
    {
        public string Name { get; set; }
    }

    class eSupportDriverFile
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string URL { get; set; }
        public string Size { get; set; }
        public string SHA256 { get; set; }
    }

    class eSupportDriverDate
    {
        public double Unix { get; set; }
    }

    class JSONModelEntity
    {
        public string Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Serial { get; set; }
        public string Type { get; set; }
        public string ParentID { get; set; }
        public string Popularity { get; set; }
    }//end JSONEntity

    /**
    * Class to deserialize the JSON into
*/
    class JSONApplicationEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public IList<JSONCategories> Categories { get; set; }
        public IList<JSONFiles> Files { get; set; }
        public IList<string> OperatingSystems { get; set; }
    }//end JSONEntity

    class JSONFiles
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Priority { get; set; }
        public string Type { get; set; }
        public string URL { get; set; }
        public string Version { get; set; }
        public string SHA256 { get; set; }
    }

    class JSONCategories
    {
        public string Name { get; set; }
        public string Class { get; set; }
    }
}
