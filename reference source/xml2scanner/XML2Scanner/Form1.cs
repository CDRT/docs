using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace XML2Scanner
{

    // 
    // command line options for debugging (set in project properties)
    // 
    // -os=win8 -allmt -url=download.lenovo.com/67267/test/catalog
    // 
    // 


    public partial class Form1
    {

        #region Globals
        private string catalog_base_path = "";
        private string catalog_base_pathX = "http://download.lenovo.com/catalog/";
        private string catalog_base_pathS = "https://download.lenovo.com/catalog/";
        private string package_base_path = "http://download.lenovo.com/ibmdl/pub/pc/pccbbs/";
        private string local_base_path = Application.UserAppDataPath + @"\";
        // DECLARE THIS WITHEVENTS SO WE GET EVENTS ABOUT DOWNLOAD PROGRESS
        private WebFileDownloader __Downloader;

        private WebFileDownloader _Downloader
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return __Downloader;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                __Downloader = value;
            }
        }
        public DataSet ds;
        public BindingSource bindingSource;
        private string taxonomy = @".\taxonomy.ini";
        private List<string> mt = new List<string>();
        private List<string> subseries = new List<string>();
        private List<string> badCatalogCRC = new List<string>();
        private List<string> downlevelPackages = new List<string>();
        private int cnt = 0;
        private string key = @"HKEY_CURRENT_USER\Software\Lenovo\XML2Scanner";
        // Private cmd As Boolean = False
        private bool allmt = false;
        private bool alternateURL = false;

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        private string tstamper()
        {
            string y = DateTime.Now.Year.ToString();
            string m = DateTime.Now.Month.ToString();
            if (m.Length == 1)
            {
                m = "0" + m;
            }
            string d = DateTime.Now.Day.ToString();
            if (d.Length == 1)
            {
                d = "0" + d;
            }
            string h = DateTime.Now.Hour.ToString();
            if (h.Length == 1)
            {
                h = "0" + h;
            }
            string mm = DateTime.Now.Minute.ToString();
            if (mm.Length == 1)
            {
                mm = "0" + mm;
            }
            string s = DateTime.Now.Second.ToString();
            if (s.Length == 1)
            {
                s = "0" + s;
            }

            return y + "-" + m + "-" + d + "_" + h + mm + s;

        }


        #region Form handlers
        private void processArgs()
        {
            try
            {
                var CommandLineArgs = My.MyProject.Application.CommandLineArgs;
                bool flagMTSearch = false;
                bool flagGoodArgs = false;
                string mt = "";
                string os = "all";
                bool clearcache = false;
                bool https = false;


                foreach (string s in CommandLineArgs)
                {
                    s = s.ToLower();
                    string[] arg = s.Split('=');
                    switch (arg[0].Trim() ?? "")
                    {

                        case "-help":
                            {
                                Interaction.MsgBox("Command line help:" + Constants.vbCrLf + "-mt=<MT>  Specifies to search just for the 4-character machine type provided" + Constants.vbCrLf + "-os=<OS>  Specifies the OS to search for: xp, vista, win7, win8, all" + Constants.vbCrLf + "-allmt    Specifies to do a search for all machine types in the taxonomy.ini for infrastructure testing");

                                Close();
                                break;
                            }

                        case "-mt":
                            {
                                if (arg[1].Trim().Length != 4)
                                {
                                    flagGoodArgs = false;
                                }
                                else
                                {
                                    flagMTSearch = true;
                                    mt = arg[1].Trim().ToUpper();
                                    if (!("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(Conversions.ToString(mt[0])) & "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(Conversions.ToString(mt[1])) & "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(Conversions.ToString(mt[2])) & "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(Conversions.ToString(mt[3]))))
                                    {
                                        flagGoodArgs = false;
                                    }
                                    else
                                    {
                                        flagGoodArgs = true;
                                        TextBox1.Text = mt;
                                    }

                                }

                                break;
                            }


                        case "-os":
                            {
                                if (arg[1].Trim().ToLower() == "win10")
                                {
                                    os = "win10";
                                    _rbWin10.Checked = true;
                                    _rbWin7.Checked = false;
                                    _rbWin81.Checked = false;
                                    ComboBox1.SelectedIndex = 4;
                                    cbWin10.CheckState = CheckState.Checked;
                                    cbWin8.CheckState = CheckState.Unchecked;
                                    cbWin7.CheckState = CheckState.Unchecked;
                                    cbWinXP.CheckState = CheckState.Unchecked;
                                    cbWinVista.CheckState = CheckState.Unchecked;
                                    flagGoodArgs = true;
                                }
                                else if (arg[1].Trim().ToLower() == "win8")
                                {
                                    os = "win8";
                                    _rbWin81.Checked = true;
                                    _rbWin7.Checked = false;
                                    _rbWin10.Checked = false;
                                    ComboBox1.SelectedIndex = 3;
                                    cbWin8.CheckState = CheckState.Checked;
                                    cbWin10.CheckState = CheckState.Unchecked;
                                    cbWin7.CheckState = CheckState.Unchecked;
                                    cbWinXP.CheckState = CheckState.Unchecked;
                                    cbWinVista.CheckState = CheckState.Unchecked;
                                    flagGoodArgs = true;
                                }
                                else if (arg[1].Trim().ToLower() == "win7")
                                {
                                    os = "win7";
                                    _rbWin7.Checked = true;
                                    _rbWin81.Checked = false;
                                    _rbWin10.Checked = false;
                                    ComboBox1.SelectedIndex = 2;
                                    cbWin7.CheckState = CheckState.Checked;
                                    cbWin10.CheckState = CheckState.Unchecked;
                                    cbWin8.CheckState = CheckState.Unchecked;
                                    cbWinXP.CheckState = CheckState.Unchecked;
                                    cbWinVista.CheckState = CheckState.Unchecked;
                                    flagGoodArgs = true;
                                }
                                else if (arg[1].Trim().ToLower() == "xp")
                                {
                                    os = "xp";
                                    ComboBox1.SelectedIndex = 0;
                                    cbWinXP.CheckState = CheckState.Checked;
                                    cbWin10.CheckState = CheckState.Unchecked;
                                    cbWin8.CheckState = CheckState.Unchecked;
                                    cbWin7.CheckState = CheckState.Unchecked;
                                    cbWinVista.CheckState = CheckState.Unchecked;
                                    flagGoodArgs = true;
                                }
                                else if (arg[1].Trim().ToLower() == "vista")
                                {
                                    os = "vista";
                                    ComboBox1.SelectedIndex = 1;
                                    cbWinVista.CheckState = CheckState.Checked;
                                    cbWin7.CheckState = CheckState.Unchecked;
                                    cbWin10.CheckState = CheckState.Unchecked;
                                    cbWin8.CheckState = CheckState.Unchecked;
                                    cbWinXP.CheckState = CheckState.Unchecked;
                                    flagGoodArgs = true;
                                }
                                else if (arg[1].Trim().ToLower() == "all")
                                {
                                    os = "all";
                                    cbWinVista.CheckState = CheckState.Checked;
                                    cbWinXP.CheckState = CheckState.Checked;
                                    cbWin7.CheckState = CheckState.Checked;
                                    cbWin8.CheckState = CheckState.Checked;
                                    cbWin10.CheckState = CheckState.Checked;
                                    flagGoodArgs = true;
                                }
                                else
                                {
                                    flagGoodArgs = false;
                                }
                                Update();
                                break;
                            }

                        case "-clearcache":
                            {
                                clearcache = true;
                                flagGoodArgs = true;
                                break;
                            }

                        case "-https":
                            {
                                https = true;
                                CheckBox1.CheckState = CheckState.Checked;
                                flagGoodArgs = true;
                                break;
                            }

                        case "-allmt":
                            {
                                allmt = true;
                                flagGoodArgs = true;
                                break;
                            }

                        case "-url":
                            {
                                alternateURL = true;
                                catalog_base_pathX = "http://" + arg[1];
                                catalog_base_pathS = "https://" + arg[1];
                                flagGoodArgs = true;
                                break;
                            }

                        default:
                            {
                                flagGoodArgs = false;
                                break;
                            }

                    }

                }
                if ((os == "all" | string.IsNullOrEmpty(os)) & flagMTSearch)
                {
                    Interaction.MsgBox("You must specify an OS when performing a single machine type audit.");
                    Application.Exit();
                }
                if (CommandLineArgs.Count > 0)
                {
                    if (flagGoodArgs)
                    {
                        if (flagMTSearch)
                        {
                            // Me.cmd = True
                            // Console.WriteLine("[" & tstamper() & "] Performing a catalog search for " & mt & " and " & os)
                            btnSearchCatalog.PerformClick();
                            // Console.WriteLine("[" & tstamper() & "] Completed. Writing log file.")
                            writeLog(true);
                            if (clearcache)
                            {
                                // Console.WriteLine("[" & tstamper() & "] Clearing cache.")
                                btnClear.PerformClick();
                            }
                        }
                        else
                        {
                            // Console.WriteLine("[" & tstamper() & "] Performing multiple catalog scan")
                            btnThink.PerformClick();

                            if (clearcache)
                            {
                                // Console.WriteLine("[" & tstamper() & "] Clearing cache.")
                                btnClear.PerformClick();
                            }
                        }
                    }
                    else
                    {
                        Interaction.MsgBox("Usage:  XML2Scanner.exe [-mt=1234] [-os=win8|win7|vista|xp|all] [-https] [-clearcache] [-allmt]" + Constants.vbCrLf + "For a complete catalog audit, specify -os=all");
                    }
                    Application.Exit();
                }
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("ERROR: " + ex.Message.ToString());
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Directory.GetCurrentDirectory() = My.MyProject.Application.Info.DirectoryPath;

            setStatus("Saving files to: " + local_base_path);
            ComboBox1.SelectedIndex = 4;
            _rbWin10.Checked = true;

            try
            {
                TextBox1.Text = Conversions.ToString(My.MyProject.Computer.Registry.GetValue(key, "LastMT", ""));
                string lastOS = Conversions.ToString(My.MyProject.Computer.Registry.GetValue(key, "LastOS", "Win10"));
                switch (lastOS ?? "")
                {
                    case "Win10":
                        {
                            _rbWin10.Checked = true;
                            break;
                        }

                    case "Win7":
                        {
                            _rbWin7.Checked = true;
                            break;
                        }

                    case "Win8":
                        {
                            _rbWin81.Checked = true;
                            break;
                        }

                    default:
                        {
                            _rbWin10.Checked = true;
                            break;
                        }

                }
            }

            catch (Exception ex)
            {
                TextBox1.Text = "20E1";
            }

            TextBox1.CharacterCasing = CharacterCasing.Upper;
            Text = Text + " - " + My.MyProject.Application.Info.Version.ToString();
            ListBox1.SelectedIndex = -1;
            CheckBox1.CheckState = CheckState.Unchecked;
            catalog_base_path = catalog_base_pathX;
            // If Me.TextBox1.Text <> "" And Me.ComboBox1.SelectedIndex <> -1 Then
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {
                AcceptButton = btnSearchCatalog;
            }

            // ds = New DataSet
            // ds.Tables.Add("packages")
            // ds.Tables("packages").Columns.Add("pkgid")
            // ds.Tables("packages").Columns.Add("title")
            // ds.Tables("packages").Columns.Add("released")
            // ds.Tables("packages").Columns.Add("crc")
            // bindingSource.DataSource = ds.Tables("packages")

            // Me.DataGridView1.DataSource = bindingSource
            processArgs();

        }

        private void btnSearchCatalog_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            DataGridView1.Rows.Clear();
            My.MyProject.Computer.Registry.SetValue(key, "LastMT", TextBox1.Text.ToString());
            if (_rbWin10.Checked)
            {
                My.MyProject.Computer.Registry.SetValue(key, "LastOS", "Win10");
            }
            else if (_rbWin7.Checked)
            {
                My.MyProject.Computer.Registry.SetValue(key, "LastOS", "Win7");
            }
            else if (_rbWin81.Checked)
            {
                My.MyProject.Computer.Registry.SetValue(key, "LastOS", "Win8");
            }

            TabControl1.SelectedTab = tp_status;
            ProcessCatalog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox2.Text))
            {
                string s = TextBox2.Text;
                if (!s.Contains("_2_.xml"))
                {
                    s = s + "_2_.xml";
                }
                ProcessPackage(s);
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text.ToUpper();
            if (TextBox1.Text.Length == 4)
            {
                if (_rbWin7.Checked | _rbWin81.Checked | _rbWin10.Checked)
                {
                    btnSearchCatalog.Enabled = true;
                    btnSearchCatalog.Focus();
                }
                else
                {
                    btnSearchCatalog.Enabled = false;
                }
            }
            else
            {
                btnSearchCatalog.Enabled = false;
            }

            AcceptButton = btnSearchCatalog;

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (TextBox2.Text.Length > 6)
            {
                Button2.Enabled = true;
            }

            AcceptButton = Button2;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex > -1)
            {
                btnSearchCatalog.Enabled = true;
            }
            else
            {
                btnSearchCatalog.Enabled = false;
            }
        }

        private void _rbWin7_CheckedChanged(object sender, EventArgs e)
        {
            if (_rbWin7.Checked | _rbWin81.Checked | _rbWin10.Checked)
            {
                btnSearchCatalog.Enabled = true;
            }
            else
            {
                btnSearchCatalog.Enabled = false;
            }
        }

        private void setStatus(string texts)
        {
            ListBox1.Items.Add(texts);
            ListBox1.SelectedItems.Clear();
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1;
            Update();
        }

        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Process.Start(Operators.ConcatenateObject(Operators.ConcatenateObject(DataGridView1.CurrentRow.Cells["xml2_path"].Value, "?t="), DateTime.Now.Ticks.ToString()));
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Could not load XML2 file:" + ex.Message.ToString());
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string CopytoClip;
            int I;
            Clipboard.Clear();
            CopytoClip = "";
            var loopTo = ListBox1.SelectedItems.Count - 1;
            for (I = 0; I <= loopTo; I++)


                CopytoClip = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(CopytoClip, ListBox1.SelectedItems[I]), Constants.vbCrLf));
            Clipboard.SetText(CopytoClip);
        }

        #endregion

        #region Catalog Handlers
        public string getSHA256hash(string fileName)
        {
            try
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    return "";
                }

                if (!File.Exists(fileName))
                {
                    return "";
                }

                var fs = new FileStream(fileName, FileMode.Open);
                var sha = new SHA256Managed();
                byte[] result = sha.ComputeHash(fs);
                fs.Close();
                return BitConverter.ToString(result).Replace("-", "");
            }

            catch (Exception ex)
            {
                return "";
            }
        }

        private void setColumns()
        {
            try
            {
                DataGridView1.Columns["PkgID"].Visible = cbPackageID.Checked;
                DataGridView1.Columns["PackageName"].Visible = cbPackageName.Checked;
                DataGridView1.Columns["Title"].Visible = cbTitle.Checked;
                DataGridView1.Columns["Version"].Visible = cbVersion.Checked;
                DataGridView1.Columns["Released"].Visible = cbReleased.Checked;
                DataGridView1.Columns["PackageType"].Visible = cbPackageType.Checked;
                DataGridView1.Columns["category"].Visible = cbCategory.Checked;
                DataGridView1.Columns["RebootType"].Visible = cbReboot.Checked;
                DataGridView1.Columns["Severity"].Visible = cbSeverity.Checked;
                DataGridView1.Columns["Brand"].Visible = cbBrand.Checked;
                DataGridView1.Columns["Setup"].Visible = cbSetup.Checked;
                DataGridView1.Columns["language"].Visible = cbLanguage.Checked;
                DataGridView1.Columns["Valid"].Visible = cbValid.Checked;
                DataGridView1.Columns["xml2_path"].Visible = cbXML2Path.Checked;
                DataGridView1.Columns["CRC"].Visible = cbCRC_Catalog.Checked;
                DataGridView1.Columns["crcactual"].Visible = cbCRC_Actual.Checked;
                DataGridView1.Columns["Comment"].Visible = cbComment.Checked;
            }

            catch (Exception ex)
            {

            }
        }
        private string getOSsuffix()
        {
            string OS_suffix = "";
            if (_rbWin7.Checked)
            {
                OS_suffix = "Win7";
            }
            else if (_rbWin81.Checked)
            {
                OS_suffix = "Win8";
            }
            else if (_rbWin10.Checked)
            {
                OS_suffix = "Win10";
            }
            else
            {
                OS_suffix = "Win10";
            }
            return OS_suffix;
        }
        private void ProcessCatalog()
        {
            try
            {
                string OS_suffix = getOSsuffix();

                string file_to_download = TextBox1.Text + "_" + OS_suffix + ".xml";
                string desc_to_download = TextBox1.Text + "_" + OS_suffix + "_DESC.xml";
                setStatus("Downloading catalog descriptor: " + catalog_base_path + desc_to_download);

                _Downloader = new WebFileDownloader();
                if (_Downloader.DownloadFileWithProgress(catalog_base_path + desc_to_download + "?t=" + DateTime.Now.Ticks.ToString(), local_base_path + desc_to_download))
                {


                    setStatus("Downloading catalog: " + catalog_base_path + file_to_download);
                    setStatus("To: " + local_base_path + file_to_download);

                    if (_Downloader.DownloadFileWithProgress(catalog_base_path + file_to_download + "?t=" + DateTime.Now.Ticks.ToString(), local_base_path + file_to_download))
                    {

                        string expectedCRC = getCatalogCRC(local_base_path + desc_to_download).ToLower();
                        setStatus("Expected CRC: " + expectedCRC);

                        string actualCRC = getSHA256hash(local_base_path + file_to_download).ToLower();
                        setStatus("Actual CRC: " + actualCRC);

                        if ((expectedCRC ?? "") == (actualCRC ?? ""))
                        {
                            setStatus("CRCs Match!!");
                        }
                        else
                        {
                            setStatus("** CRCs DO NOT MATCH!! **");
                        }
                        var pkgNameList = new List<string>();
                        var pkgsList = getPackages(local_base_path + file_to_download);
                        var pkgNameListDL = new List<string>();
                        if (pkgsList is not null)
                        {
                            // Loop through and add pkg to DataGridView1
                            foreach (_package pkg in pkgsList)
                            {
                                DataGridView1.Rows.Add(pkg.CPkgID, pkg.CPackageName, pkg.CTitle, pkg.CVersion, pkg.CReleased, pkg.CPackageType, pkg.CCategory, pkg.CReboot, pkg.CSeverity, pkg.CBrand, pkg.Csetup, pkg.Clangs, pkg.Cxml2valid, pkg.CURLxml2, pkg.Cxml2crc, pkg.Cxml2crcactual);

                                if (pkgNameList.Contains(pkg.CPackageName))
                                {
                                    if (!pkgNameListDL.Contains(pkg.CPackageName))
                                    {
                                        pkgNameListDL.Add(pkg.CPackageName);
                                    }
                                }
                                else
                                {
                                    pkgNameList.Add(pkg.CPackageName);
                                }

                            }
                            if (pkgNameListDL.Count > 0)
                            {
                                foreach (string z in pkgNameListDL)
                                {
                                    foreach (_package y in pkgsList)
                                    {
                                        if ((z ?? "") == (y.CPackageName ?? ""))
                                        {
                                            downlevelPackages.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(y.CPkgID + Constants.vbTab + y.CPackageName + Constants.vbTab + Conversions.ToString(y.CReleased) + Constants.vbTab + "http://download.lenovo.com/catalog/" + TextBox1.Text + "_", ComboBox1.SelectedItem), ".xml"), Constants.vbTab), y.CURLxml2)));
                                        }
                                    }
                                }
                            }
                        }
                        setColumns();
                        DataGridView1.AutoResizeColumns();
                        DataGridView1.Sort(DataGridView1.Columns["Valid"], System.ComponentModel.ListSortDirection.Ascending);
                        SetBGColor();
                        setStatus("Got all packages.");
                        TabControl1.SelectedTab = tp_packages;
                    }

                    else
                    {
                        setStatus("Could not download catalog.");

                        string expectedCRC = getCatalogCRC(local_base_path + desc_to_download).ToLower();
                        setStatus("Expected CRC: " + expectedCRC);

                        string actualCRC = getSHA256hash(local_base_path + file_to_download).ToLower();
                        setStatus("Actual CRC: " + actualCRC);

                        if ((expectedCRC ?? "") == (actualCRC ?? ""))
                        {
                            setStatus("CRCs Match!!");
                        }
                        else
                        {
                            setStatus("** CRCs DO NOT MATCH!! **");
                        }

                        var pkgsList = getPackages(local_base_path + file_to_download);
                        if (pkgsList is not null)
                        {
                            // Loop through and add pkg to DataGridView1
                            foreach (_package pkg in pkgsList)
                                // Dim dRow As DataRow = ds.Tables("packages").NewRow()
                                // dRow.Item(0) = pkg.CPkgID
                                // dRow.Item(1) = pkg.CTitle
                                // dRow.Item(2) = ""
                                // dRow.Item(3) = pkg.Cxml2crc
                                // ds.Tables("packages").Rows.Add(dRow)

                                DataGridView1.Rows.Add(pkg.CPkgID, pkg.CPackageName, pkg.CTitle, pkg.CVersion, pkg.CReleased, pkg.CPackageType, pkg.CCategory, pkg.CReboot, pkg.CSeverity, pkg.CBrand, pkg.Csetup, pkg.Clangs, pkg.Cxml2valid, pkg.CURLxml2, pkg.Cxml2crc, pkg.Cxml2crcactual);
                        }
                        DataGridView1.AutoResizeColumns();
                        setStatus("Got all packages.");
                        TabControl1.SelectedTab = tp_packages;


                    }
                }
                else
                {
                    setStatus("Could not download catalog descriptor.");
                }
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("ProcessCatalog: " + ex.Message.ToString());
            }
        }

        private string getCatalogCRC(string catalog)
        {
            try
            {
                XmlDocument m_xmld;
                XmlNodeList m_nodelist;

                // Create the XML Document
                m_xmld = new XmlDocument();

                // Load the Xml file
                m_xmld.Load(catalog);

                // Get the list of name nodes
                m_nodelist = m_xmld.SelectNodes("/catalog");

                // Loop through the nodes
                foreach (XmlNode m_node in m_nodelist)
                {

                    // Get the location Element Value
                    string locationValue = m_node.ChildNodes.Item(0).InnerText;

                    // Get the checksum Element Value
                    string crcValue = m_node.ChildNodes.Item(1).InnerText;

                    return crcValue;
                }
                return "";
            }

            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message.ToString());
                return "";
            }
        }
        #endregion

        #region Package Handlers
        public string getSHAhash(string fileName, string hashtype)
        {
            try
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    return "";
                }

                if (!File.Exists(fileName))
                {
                    return "";
                }

                var fs = new FileStream(fileName, FileMode.Open);
                var sha = new SHA1Managed();
                var sha256 = new SHA256Managed();
                var result = default(byte[]);
                switch (hashtype ?? "")
                {
                    case "sha1":
                        {
                            result = sha.ComputeHash(fs);
                            break;
                        }

                    case "sha256":
                        {
                            result = sha256.ComputeHash(fs);
                            break;
                        }

                }

                fs.Close();
                return BitConverter.ToString(result).Replace("-", "");
            }

            catch (Exception ex)
            {
                return "";
            }
        }

        private List<_package> getPackages(string catalog)
        {
            try
            {
                var m_list = new List<_package>();
                XmlDocument m_xmld;
                XmlNodeList m_nodelist;

                // Create the XML Document
                m_xmld = new XmlDocument();

                // Load the Xml file
                m_xmld.Load(catalog);

                // Get the list of package nodes
                m_nodelist = m_xmld.SelectNodes("/packages/package");

                setStatus("Total packages (" + catalog.Substring(catalog.LastIndexOf(@"\") + 1) + "): " + m_nodelist.Count.ToString());
                setStatus("Getting details for packages, please wait...");

                // Loop through the nodes
                foreach (XmlNode m_node in m_nodelist)
                {
                    var thisPkg = new _package();
                    // Get the location Element Value
                    thisPkg.CURLxml2 = m_node.ChildNodes.Item(0).InnerText;

                    // Get package ID
                    int dot = thisPkg.CURLxml2.LastIndexOf(".");
                    if (dot > 30)
                    {
                        thisPkg.CPkgID = thisPkg.CURLxml2.Substring(thisPkg.CURLxml2.LastIndexOf("/") + 1, thisPkg.CURLxml2.LastIndexOf(".") - thisPkg.CURLxml2.LastIndexOf("/") - 4);
                        // Get the category
                        thisPkg.CCategory = m_node.ChildNodes.Item(1).InnerText;

                        // Get the languages
                        XmlNodeList m_nodelist_langs;
                        string langs = "";
                        m_nodelist_langs = m_node.ChildNodes.Item(2).ChildNodes;
                        foreach (XmlNode m_node_lang in m_nodelist_langs)
                            langs += m_node_lang.InnerText + ", ";
                        if (langs.Length > 2)
                        {
                            langs = langs.Substring(0, langs.Length - 2);
                        }

                        thisPkg.Clangs = langs;

                        // Get the checksum Element Value
                        thisPkg.Cxml2crc = m_node.ChildNodes.Item(3).InnerText;

                        // Get title and release date
                        getTitle(ref thisPkg);
                    }
                    else
                    {
                        thisPkg.CTitle = "Issue encountered with XML Package Descriptor file.";
                    }

                    m_list.Add(thisPkg);
                }
                return m_list;
            }
            catch (Exception ex)
            {
                // setStatus("getPackages: " & ex.Message.ToString)
                return null;

            }

        }

        private void getTitle(ref _package thisPkg)
        {
            try
            {
                _Downloader = new WebFileDownloader();
                _Downloader.DownloadFileWithProgress(thisPkg.CURLxml2 + "?t=" + DateTime.Now.Ticks.ToString(), local_base_path + thisPkg.CPkgID + "_2_.xml");
                XmlDocument m_xmld;
                XmlNodeList m_nodelist;
                // Dim m_node As XmlNode

                // Create the XML Document
                m_xmld = new XmlDocument();

                // Load the Xml file
                m_xmld.Load(local_base_path + thisPkg.CPkgID + "_2_.xml");

                // Get the PackageName
                m_nodelist = m_xmld.SelectNodes("/Package");
                thisPkg.CPackageName = m_nodelist.Item(0).Attributes["name"].Value;
                thisPkg.CVersion = m_nodelist.Item(0).Attributes["version"].Value;

                // Get the Title node and pull text for <Desc> child node
                m_nodelist = m_xmld.SelectNodes("/Package/Title");
                thisPkg.CTitle = m_nodelist.Item(0).ChildNodes.Item(0).InnerText;

                // Get the ReleaseDate node and pull innertext
                m_nodelist = m_xmld.SelectNodes("/Package/ReleaseDate");
                thisPkg.CReleased = Conversions.ToDate(m_nodelist.Item(0).InnerText);

                // Get the PackageType node and pull "type" attribute
                m_nodelist = m_xmld.SelectNodes("/Package/PackageType");
                switch (m_nodelist.Item(0).Attributes["type"].Value ?? "")
                {
                    case "1":
                        {
                            thisPkg.CPackageType = "1|Application";
                            break;
                        }

                    case "2":
                        {
                            thisPkg.CPackageType = "2|Driver";
                            break;
                        }

                    case "3":
                        {
                            thisPkg.CPackageType = "3|BIOS";
                            break;
                        }

                    case "4":
                        {
                            thisPkg.CPackageType = "4|Firmware";
                            break;
                        }

                    default:
                        {
                            thisPkg.CPackageType = "Other";
                            break;
                        }
                }

                // Get the Severity node and pull "type" attribute
                m_nodelist = m_xmld.SelectNodes("/Package/Severity");
                switch (m_nodelist.Item(0).Attributes["type"].Value ?? "")
                {
                    case "1":
                        {
                            thisPkg.CSeverity = "1|Critical";
                            break;
                        }

                    case "2":
                        {
                            thisPkg.CSeverity = "2|Recommended";
                            break;
                        }

                    case "3":
                        {
                            thisPkg.CSeverity = "3|Optional";
                            break;
                        }

                    default:
                        {
                            thisPkg.CSeverity = "Optional";
                            break;
                        }
                }

                // Get the Brand node and pull "type" attribute
                m_nodelist = m_xmld.SelectNodes("/Package/Brand");
                switch (m_nodelist.Item(0).Attributes["type"].Value ?? "")
                {
                    case "1":
                        {
                            thisPkg.CBrand = "1|All";
                            break;
                        }

                    case "2":
                        {
                            thisPkg.CBrand = "2|Think";
                            break;
                        }

                    case "3":
                        {
                            thisPkg.CBrand = "3|Lenovo Notebook";
                            break;
                        }

                    case "4":
                        {
                            thisPkg.CBrand = "4|Lenovo Desktop";
                            break;
                        }

                    default:
                        {
                            thisPkg.CBrand = "Other";
                            break;
                        }
                }

                // Get the Reboot node and pull "type" attribute
                m_nodelist = m_xmld.SelectNodes("/Package/Reboot");
                switch (m_nodelist.Item(0).Attributes["type"].Value ?? "")
                {
                    case "0":
                        {
                            thisPkg.CReboot = "0|No Reboot Required";
                            break;
                        }

                    case "1":
                        {
                            thisPkg.CReboot = "1|Forces Reboot";
                            break;
                        }

                    case "2":
                        {
                            thisPkg.CReboot = "2|Reserved";
                            break;
                        }

                    case "3":
                        {
                            thisPkg.CReboot = "3|Requires a Reboot";
                            break;
                        }

                    case "4":
                        {
                            thisPkg.CReboot = "4|Forces Shutdown";
                            break;
                        }

                    case "5":
                        {
                            thisPkg.CReboot = "5|Forced Reboot Delayed";
                            break;
                        }

                    default:
                        {
                            thisPkg.CReboot = "Other";
                            break;
                        }
                }

                // Get the setup command
                m_nodelist = m_xmld.SelectNodes("/Package/Install");
                thisPkg.Csetup = m_nodelist.Item(0).ChildNodes.Item(0).InnerText;

                // get detectinstall and add to file
                // m_nodelist = m_xmld.SelectNodes("/Package/DetectInstall")
                // Dim di As String = m_nodelist.Item(0).InnerXml
                // My.Computer.FileSystem.WriteAllText(local_base_path & "\di.xml", thisPkg.CPkgID & vbCrLf & di & vbCrLf & vbCrLf, True)

                // get the readme file
                m_nodelist = m_xmld.SelectNodes("/Package/Files/Readme/File");
                _Downloader = new WebFileDownloader();
                if (_Downloader.DownloadFileWithProgress(thisPkg.CURLxml2.Substring(0, thisPkg.CURLxml2.LastIndexOf("/") + 1) + m_nodelist.Item(0).ChildNodes.Item(0).InnerText + "?t=" + DateTime.Now.Ticks.ToString(), local_base_path + m_nodelist.Item(0).ChildNodes.Item(0).InnerText))
                {
                    thisPkg.CURLtxt = thisPkg.CURLxml2.Substring(0, thisPkg.CURLxml2.LastIndexOf("/") + 1) + m_nodelist.Item(0).ChildNodes.Item(0).InnerText;
                }

                if (File.Exists(local_base_path + thisPkg.CPkgID + "_2_.xml"))
                {
                    thisPkg.Cxml2crcactual = getSHA256hash(local_base_path + thisPkg.CPkgID + "_2_.xml").ToLower();
                    if ((thisPkg.Cxml2crc ?? "") == (thisPkg.Cxml2crcactual ?? ""))
                    {
                        thisPkg.Cxml2valid = "yes";
                    }
                    else
                    {
                        thisPkg.Cxml2valid = "no";
                    }

                }
            }

            catch (Exception ex)
            {
                // setStatus("getTitle: " & ex.Message.ToString)
            }
        }


        private void ProcessPackage(string pkgid, string xmlUrl = "")
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                string found = "";
                bool search = false;
                if (string.IsNullOrEmpty(xmlUrl) & !string.IsNullOrEmpty(pkgid))
                {
                    search = true;
                    string file_mobiles = package_base_path + "mobiles/" + pkgid;
                    string file_thinkcentre = package_base_path + "thinkcentre_drivers/" + pkgid;
                    string file_tvt = package_base_path + "thinkvantage_en/" + pkgid;
                    string file_thinkcentre_bios = package_base_path + "thinkcentre_bios/" + pkgid;
                    string file_thinkcentre_sw = package_base_path + "thinkcentre_software/" + pkgid;
                    string file_options = package_base_path + "options/" + pkgid;

                    setStatus("Searching for package: " + pkgid);

                    _Downloader = new WebFileDownloader();
                    if (_Downloader.DownloadFileWithProgress(file_mobiles + "?t=" + DateTime.Now.Ticks.ToString(), local_base_path + pkgid))
                    {
                        found = file_mobiles;
                    }
                    if (_Downloader.DownloadFileWithProgress(file_thinkcentre + "?t=" + DateTime.Now.Ticks.ToString(), local_base_path + pkgid))
                    {
                        found = file_thinkcentre;
                    }
                    if (_Downloader.DownloadFileWithProgress(file_tvt + "?t=" + DateTime.Now.Ticks.ToString(), local_base_path + pkgid))
                    {
                        found = file_tvt;
                    }
                    if (_Downloader.DownloadFileWithProgress(file_thinkcentre_bios + "?t=" + DateTime.Now.Ticks.ToString(), local_base_path + pkgid))
                    {
                        found = file_thinkcentre_bios;
                    }
                    if (_Downloader.DownloadFileWithProgress(file_thinkcentre_sw + "?t=" + DateTime.Now.Ticks.ToString(), local_base_path + pkgid))
                    {
                        found = file_thinkcentre_sw;
                    }
                    if (_Downloader.DownloadFileWithProgress(file_options + "?t=" + DateTime.Now.Ticks.ToString(), local_base_path + pkgid))
                    {
                        found = file_options;
                    }
                }
                else if (string.IsNullOrEmpty(pkgid) & !string.IsNullOrEmpty(xmlUrl))
                {
                    search = false;
                    found = xmlUrl;
                }

                if (!string.IsNullOrEmpty(found) & search)
                {
                    setStatus("Found package: " + found);
                    Process.Start(found);
                    string exeFileName = "";
                    if (checkExe(found, ref exeFileName))
                    {
                        setStatus("Installer CRC valid: " + exeFileName);
                    }
                    else
                    {
                        setStatus("** INSTALLER (" + exeFileName + ") CRC INVALID!!! **");
                    }
                }
                else if (!string.IsNullOrEmpty(found) & !search)
                {
                    string exeFileName = "";
                    if (checkExe(found, ref exeFileName))
                    {
                        Interaction.MsgBox("CRC check of the executable file(s), " + exeFileName + ", passed.", MsgBoxStyle.Information, "CRC is valid");
                    }
                    else
                    {
                        Interaction.MsgBox("** CRC check of the executable file(s), " + exeFileName + ", failed!!! **", MsgBoxStyle.Critical, "Invalid CRC");
                    }
                }
                else
                {
                    setStatus("Package not found!");
                }
                Cursor = Cursors.Arrow;
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("ProcessPackage: " + ex.Message.ToString());
            }
        }

        public bool checkExe(string xmlUrl, [Optional] ref string exeRef)
        {

            try
            {
                var m_list = new List<_package>();
                XmlDocument m_xmld;
                XmlNodeList m_nodelist;
                XmlNode m_node;
                bool installerCheck = true;
                bool externalCheck = true;
                string installer = "";
                string external = "";

                // Create the XML Document
                m_xmld = new XmlDocument();

                // Load the Xml file
                m_xmld.Load(xmlUrl + "?t=" + DateTime.Now.Ticks.ToString());

                // Get the list of name nodes
                m_nodelist = m_xmld.SelectNodes("/Package/Files/Installer/File");
                // Loop through the nodes
                foreach (XmlNode currentM_node in m_nodelist)
                {
                    m_node = currentM_node;
                    string exe = "";
                    string expected = "";
                    string exeURL = xmlUrl.Substring(0, xmlUrl.LastIndexOf("/") + 1);
                    // Get the location of exe
                    exe = m_node.ChildNodes.Item(0).InnerText;
                    installer = exe;
                    exeURL = exeURL + exe;
                    expected = m_node.ChildNodes.Item(1).InnerText;
                    string hashtype = "";
                    if (expected.Length > 41)
                    {
                        hashtype = "sha256";
                    }
                    else
                    {
                        hashtype = "sha1";
                    }

                    _Downloader = new WebFileDownloader();
                    if (_Downloader.DownloadFileWithProgress(exeURL, local_base_path + exe))
                    {
                        string actual = getSHAhash(local_base_path + exe, hashtype);
                        if ((expected.ToLower() ?? "") == (actual.ToLower() ?? ""))
                        {
                            installerCheck = true;
                        }
                        else
                        {
                            installerCheck = false;
                        }
                    }
                    else
                    {
                        installerCheck = false;
                    }
                }
                // check external detection files
                m_nodelist = m_xmld.SelectNodes("/Package/Files/External/File");
                foreach (XmlNode currentM_node1 in m_nodelist)
                {
                    m_node = currentM_node1;
                    string exeExternal = "";
                    string expected = "";
                    string exeURL = xmlUrl.Substring(0, xmlUrl.LastIndexOf("/") + 1);
                    // Get the location of exe
                    exeExternal = m_node.ChildNodes.Item(0).InnerText;
                    external = exeExternal;
                    exeURL = exeURL + exeExternal;
                    expected = m_node.ChildNodes.Item(1).InnerText;
                    string hashtype = "";
                    if (expected.Length > 41)
                    {
                        hashtype = "sha256";
                    }
                    else
                    {
                        hashtype = "sha1";
                    }
                    _Downloader = new WebFileDownloader();
                    if (_Downloader.DownloadFileWithProgress(exeURL, local_base_path + exeExternal))
                    {
                        string actual = getSHAhash(local_base_path + exeExternal, hashtype);
                        if ((expected.ToLower() ?? "") == (actual.ToLower() ?? ""))
                        {
                            externalCheck = true;
                        }
                        else
                        {
                            externalCheck = false;
                        }
                    }
                    else
                    {
                        externalCheck = false;
                    }
                }
                if (installerCheck & externalCheck)
                {
                    exeRef = installer + ", " + external;
                    return true;
                }
                else if (!installerCheck & externalCheck)
                {
                    exeRef = installer;
                    return false;
                }
                else if (installerCheck & !externalCheck)
                {
                    exeRef = external;
                    return false;
                }
            }
            catch (Exception ex)
            {
                setStatus("checkExe: " + ex.Message.ToString());
                return false;
            }

            return default;
        }
        #endregion

        // #Region "Download Helpers"
        // 'FIRES WHEN WE HAVE GOTTEN THE DOWNLOAD SIZE, SO WE KNOW WHAT BOUNDS TO GIVE THE PROGRESS BAR
        // Private Sub _Downloader_FileDownloadSizeObtained(ByVal iFileSize As Long) Handles _Downloader.FileDownloadSizeObtained
        // ProgBar.Value = 0
        // ProgBar.Maximum = Convert.ToInt32(iFileSize)
        // ProgBar.Visible = False
        // Me.Update()
        // End Sub

        // 'FIRES WHEN DOWNLOAD IS COMPLETE
        // Private Sub _Downloader_FileDownloadComplete() Handles _Downloader.FileDownloadComplete
        // ProgBar.Value = ProgBar.Maximum
        // 'Me.setStatus("File Download Complete")
        // ProgBar.Visible = False
        // Me.Update()
        // End Sub
        // #End Region

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                string[] files = Directory.GetFiles(local_base_path);
                int i = 0;
                foreach (string _file in files)
                {
                    i += 1;
                    File.Delete(_file);
                }
                setStatus("Cleared " + i.ToString() + " session files.");
            }
            catch (Exception ex)
            {
                setStatus("btnClear_Click(): " + ex.Message.ToString());
            }
        }

        private void btnThink_Click(object sender, EventArgs e)
        {

            if (!cbWin7.Checked & !cbWinVista.Checked & !cbWinXP.Checked & !cbWin8.Checked & !cbWin10.Checked)
            {
                return;
            }
            try
            {
                ListBox1.SelectedItems.Clear();
                ListBox1.Items.Clear();
                DataGridView1.Rows.Clear();
                TabControl1.SelectedTab = tp_status;
                StreamReader fr;
                string ln;
                if (File.Exists(taxonomy) == false)
                {
                    MessageBox.Show("Could not find taxonomy.ini file. File should exist in same directory as XML2Scanner.exe.", "Missing taxonomy", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                fr = File.OpenText(taxonomy);
                ln = fr.ReadLine();
                mt.Clear();
                subseries.Clear();
                cnt = 0;
                string scratch = "";
                string prev = "";
                while (!(ln is null))
                {
                    // Me.TextBox1.Text = ln
                    scratch = ln.Substring(0, ln.IndexOf("="));
                    if ((scratch ?? "") != (prev ?? ""))
                    {
                        mt.Add(ln.Substring(ln.Length - 4));
                        if (!allmt)
                        {
                            prev = scratch;
                        }
                    }

                    ln = fr.ReadLine();
                }
                setStatus("Found " + mt.Count.ToString() + " sub-series.");
                var start = DateTime.Now;

                setStatus("Start analysis at " + start.ToString("H:mm:ss"));
                setStatus(" ");
                setStatus("Catalogs checked = 0");
                ListBox1.SelectedItems.Clear();
                if (mt.Count > 0)
                {
                    _Downloader = new WebFileDownloader();
                    foreach (string _mt in mt)
                    {
                        if (cbWin10.Checked)
                        {
                            mtValidate(_mt, "Win10");
                        }
                        if (cbWin8.Checked)
                        {
                            mtValidate(_mt, "Win8");
                        }
                        if (cbWin7.Checked)
                        {
                            mtValidate(_mt, "Win7");
                        }
                        if (cbWinXP.Checked)
                        {
                            mtValidate(_mt, "WinXP");
                        }
                        if (cbWinVista.Checked)
                        {
                            mtValidate(_mt, "WinVista");
                        }

                    }

                }
                var finish = DateTime.Now;
                var elapsed = finish.Subtract(start);

                ListBox1.SelectedItems.Clear();
                ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1);

                setStatus("Finished. Elapsed time = " + string.Format("{0:00}:{1:00}:{2:00}", elapsed.TotalHours, elapsed.Minutes, elapsed.Seconds));
                setStatus("Catalog Descriptors with bad CRCs = " + badCatalogCRC.Count.ToString());
                foreach (string s in badCatalogCRC)
                    setStatus(s);
                // If Me.cmd Then
                // Console.WriteLine("[" & tstamper() & "] Completed. Writing log file.")
                // End If
                writeLog();

                System.Threading.Thread.Sleep(5000);
                SetBGColor();
                TabControl1.SelectedTab = tp_packages;
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("Exception in Think(): " + ex.Message.ToString());
            }
        }

        private void mtValidate(string _mt, string _os)
        {
            try
            {

                string uriCatalogDescXP = _mt + "_WinXP_DESC.xml";
                string uriCatalogXP = _mt + "_WinXP.xml";
                string uriCatalogDesc7 = _mt + "_Win7_DESC.xml";
                string uriCatalog7 = _mt + "_Win7.xml";
                string uriCatalogDescV = _mt + "_WinVista_DESC.xml";
                string uriCatalogV = _mt + "_WinVista.xml";
                string uriCatalogDesc8 = _mt + "_Win8_DESC.xml";
                string uriCatalog8 = _mt + "_Win8.xml";
                string uriCatalogDesc10 = _mt + "_Win10_DESC.xml";
                string uriCatalog10 = _mt + "_Win10.xml";
                string targetCat = "";
                string targetCatDesc = "";
                switch (_os ?? "")
                {
                    case "Win10":
                        {
                            targetCat = uriCatalog10;
                            targetCatDesc = uriCatalogDesc10;
                            break;
                        }

                    case "Win8":
                        {
                            targetCat = uriCatalog8;
                            targetCatDesc = uriCatalogDesc8;
                            break;
                        }

                    case "WinXP":
                        {
                            targetCat = uriCatalogXP;
                            targetCatDesc = uriCatalogDescXP;
                            break;
                        }

                    case "Win7":
                        {
                            targetCat = uriCatalog7;
                            targetCatDesc = uriCatalogDesc7;
                            break;
                        }

                    case "WinVista":
                        {
                            targetCat = uriCatalogV;
                            targetCatDesc = uriCatalogDescV;
                            break;
                        }

                }
                // Win7
                string status = "Catalogs checked = ";
                _Downloader = new WebFileDownloader();
                Cursor = Cursors.WaitCursor;
                if (_Downloader.DownloadFileWithProgress(catalog_base_path + targetCatDesc, local_base_path + targetCatDesc))
                {
                    if (_Downloader.DownloadFileWithProgress(catalog_base_path + targetCat, local_base_path + targetCat))
                    {
                        string expectedCRC = getCatalogCRC(local_base_path + targetCatDesc).ToLower();

                        string actualCRC = getSHA256hash(local_base_path + targetCat).ToLower();

                        if ((expectedCRC ?? "") != (actualCRC ?? ""))
                        {
                            badCatalogCRC.Add(catalog_base_path + targetCatDesc);
                        }
                        else
                        {
                            cnt += 1;
                            int i = ListBox1.Items.Count - 1;

                            ListBox1.SelectedItems.Clear();
                            if (ListBox1.Items.Count > 1)
                            {
                                ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1);
                                ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1);
                            }
                            ListBox1.Items.Add(status + cnt.ToString());

                            var pkgsList = getPackages(local_base_path + targetCat);
                            var pkgNameList = new List<string>();
                            var pkgNameListDL = new List<string>();
                            if (pkgsList is not null)
                            {
                                // Loop through and add pkg to DataGridView1
                                foreach (_package pkg in pkgsList)
                                {
                                    // is the CRC correct?
                                    bool found = false;
                                    if (pkg.Cxml2valid == "no" | string.IsNullOrEmpty(pkg.Cxml2valid))
                                    {

                                        foreach (DataGridViewRow itm in DataGridView1.Rows)
                                        {
                                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(itm.Cells["xml2_path"].Value, pkg.CURLxml2, false)))
                                            {
                                                found = true;
                                                break;
                                            }
                                        }
                                        if (!found)
                                        {
                                            DataGridView1.Rows.Add(pkg.CPkgID, pkg.CPackageName, pkg.CTitle, pkg.CVersion, pkg.CReleased, pkg.CPackageType, pkg.CCategory, pkg.CReboot, pkg.CSeverity, pkg.CBrand, pkg.Csetup, pkg.Clangs, pkg.Cxml2valid, pkg.CURLxml2, pkg.Cxml2crc, pkg.Cxml2crcactual, _mt + "_" + _os + ".xml");
                                        }
                                    }
                                    // Is it a downlevel package?
                                    found = false;
                                    // For Each item As String In pkgNameList
                                    // If pkg.CPackageName = item Then
                                    // found = True
                                    // If Not pkgNameListDL.Contains(item) Then
                                    // pkgNameListDL.Add(item)
                                    // End If
                                    // 'Me.downlevelPackages.Add(pkg.CPkgID & vbTab & pkg.CPackageName & vbTab & "http://download.lenovo.com/catalog/" & _mt & "_" & _os & ".xml" & vbTab & pkg.CURLxml2)
                                    // Exit For
                                    // End If
                                    // Next

                                    // If Not found And pkg.CPackageName <> "" Then
                                    // pkgNameList.Add(pkg.CPackageName)
                                    // End If

                                    if (pkgNameList.Contains(pkg.CPackageName))
                                    {
                                        if (!pkgNameListDL.Contains(pkg.CPackageName))
                                        {
                                            pkgNameListDL.Add(pkg.CPackageName);
                                        }
                                    }
                                    else
                                    {
                                        pkgNameList.Add(pkg.CPackageName);
                                    }

                                }
                                if (pkgNameListDL.Count > 0)
                                {
                                    foreach (string z in pkgNameListDL)
                                    {
                                        foreach (_package y in pkgsList)
                                        {
                                            if ((z ?? "") == (y.CPackageName ?? ""))
                                            {
                                                downlevelPackages.Add(y.CPkgID + Constants.vbTab + y.CPackageName + Constants.vbTab + Conversions.ToString(y.CReleased) + Constants.vbTab + "http://download.lenovo.com/catalog/" + _mt + "_" + _os + ".xml" + Constants.vbTab + y.CURLxml2);
                                            }
                                        }
                                    }
                                }


                            }

                        }
                    }
                    else
                    {
                        ListBox1.Items.Add("Failed to download " + catalog_base_path + targetCat);
                        Update();
                    }
                }
                else
                {
                    ListBox1.Items.Add("Failed to download " + catalog_base_path + targetCatDesc);
                    Update();
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                Interaction.MsgBox("Exception in mtValidate(): " + ex.Message.ToString());
            }
        }

        private void writeLog(bool mtSearch = false)
        {
            string tstamp = tstamper(); // Now.Year.ToString & Now.Month.ToString & Now.Day.ToString & "-" & Now.Hour.ToString & Now.Minute.ToString & Now.Second.ToString
            var @out = new StreamWriter(@".\scan_log_" + tstamp + ".txt", false, System.Text.Encoding.UTF8);
            out.WriteLine("Catalog Scan Log: " + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Year.ToString() + " - " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString());
            out.WriteLine(" ");
            if (!mtSearch)
            {
                out.WriteLine("Catalogs with incorrect CRC in Catalog DESC file:");
                foreach (string s in badCatalogCRC)
                    out.WriteLine(s);
                out.WriteLine(" ");
            }

            if (!mtSearch)
            {
                out.WriteLine("Packages in Catalogs with incorrect CRC values:");
            }
            else
            {
                out.WriteLine("Packages in the catalog for " + TextBox1.Text + "_" + getOSsuffix() + ":");
            }

            string header = "";
            foreach (DataGridViewColumn ch in DataGridView1.Columns)
                header = header + ch.HeaderText + Constants.vbTab;
            out.WriteLine(header);
            try
            {
                foreach (DataGridViewRow dr in DataGridView1.Rows)
                {
                    string ln = "";
                    foreach (DataGridViewCell itm in dr.Cells)
                    {
                        if (itm.Value is null)
                        {
                            ln = ln + Constants.vbTab;
                        }
                        else
                        {
                            ln = ln + itm.Value.ToString() + Constants.vbTab;
                        }

                    }
                    out.WriteLine(ln);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Exception in writelog(): " + ex.Message.ToString());
            }

            out.WriteLine(" ");
            out.WriteLine("Down level packages:");
            out.WriteLine("Package ID" + Constants.vbTab + "Package Name" + Constants.vbTab + "Released" + Constants.vbTab + "Catalog found in" + Constants.vbTab + "Package XML2 URL");

            try
            {
                foreach (string item in downlevelPackages)
                    out.WriteLine(item);
            }
            catch (Exception ex)
            {

            }

            out.Close();

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                catalog_base_path = catalog_base_pathS;
            }
            else
            {
                catalog_base_path = catalog_base_pathX;
            }
        }

        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetBGColor();

        }

        private void SetBGColor()
        {
            int cnt = DataGridView1.Rows.Count - 1;

            while (cnt >= 0)
            {
                if (cnt % 2 == 1)
                {
                    DataGridView1.Rows[cnt].DefaultCellStyle.BackColor = Color.Cornsilk;
                }
                else
                {
                    DataGridView1.Rows[cnt].DefaultCellStyle.BackColor = Color.White;
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(DataGridView1.Rows[cnt].Cells["Valid"].Value, "yes", false)))
                {
                    DataGridView1.Rows[cnt].DefaultCellStyle.BackColor = Color.LightGray;
                    DataGridView1.Rows[cnt].DefaultCellStyle.ForeColor = Color.Blue;

                }
                cnt -= 1;
            }
        }

        private void linkTaxonomy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://download.lenovo.com/luc/bios.txt");
        }

        private void cbPackageID_CheckedChanged(object sender, EventArgs e)
        {
            setColumns();
        }

        private void cbWin7_CheckStateChanged(object sender, EventArgs e)
        {
            AcceptButton = btnThink;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count == 1)
            {
                btnCheckCRC.Enabled = true;
            }
            else
            {
                btnCheckCRC.Enabled = false;
            }
        }

        private void btnCheckCRC_Click(object sender, EventArgs e)
        {
            var row = DataGridView1.SelectedRows[0];
            string xmlURL = row.Cells["xml2_path"].Value.ToString();
            ProcessPackage("", xmlURL);
        }

        private void cbPackageID_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void linkDocks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://download.lenovo.com/luc/docks.txt");
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbColumns_Enter(object sender, EventArgs e)
        {

        }

        private void tp_status_Click(object sender, EventArgs e)
        {

        }
    }
}