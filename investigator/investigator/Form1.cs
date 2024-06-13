using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace investigator
{
    public partial class Form1 : Form
    {

        dynamic modelObj = "";
        XmlDocument doc;
        string osVersion;
        private WebFileDownloader _Downloader;
        private string catalog_base_pathX = "https://download.lenovo.com/catalog/";
        //private string catalog_base_pathS = "https://download.lenovo.com/catalog/";
        private string package_base_path = "https://download.lenovo.com/ibmdl/pub/pc/pccbbs/";
        private string local_base_path = Application.UserAppDataPath + @"\";
        private List<string> downlevelPackages = new List<string>();
        bool shiftPressed = false;

        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> cbb = new Dictionary<string, string>();
            cbb.Add("SF", "Select Family");
            cbb.Add("TC", "ThinkCentre");
            cbb.Add("TP", "ThinkPad");
            cbb.Add("TS", "ThinkStation");
            comboBrand.DataSource = new BindingSource(cbb, null);
            comboBrand.DisplayMember = "Value";
            comboBrand.ValueMember = "Key";

            radioWin11.Checked = true;

            //Reading Model List info from json file
            var machineListPath = Path.Combine(Directory.GetCurrentDirectory(), "machineSeriesList.json");
            if (File.Exists(machineListPath))
            {
                string json = File.ReadAllText(machineListPath);
                modelObj = JsonConvert.DeserializeObject(json);
            }

            //Read from catalogv2 XML
            doc = new XmlDocument();
            doc.Load("https://download.lenovo.com/cdrt/td/catalogv2.xml");

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string name = e.Argument as string;
            MessageBox.Show(name);
            //only call processCatalog here and then put backgroundWorker1.ReportProgress(i); inside processCatalog
           ProcessCatalog(name);
            
            //if you need to pass more than one thing put in hash table, list, array and pass that (make sure you grab back in the right order)

            /*for (int i = 0; i < 100; i++)
            {
                //Thread.Sleep(1000);  //dont need 
                ProcessCatalog(name);
                backgroundWorker1.ReportProgress(i); //this goes in process catalog
            }*/
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
           progressBar1.Value = e.ProgressPercentage;
        }


        private void comboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSeries.Items.Clear();
            comboSeries.Text = "Select Series";
            comboModel.Items.Clear();
            comboModel.Text = "Select Model";

            //change path to read from web
            string comboSeriesKey = ((KeyValuePair<string, string>)comboBrand.SelectedItem).Key;

            if (comboSeriesKey == "SF") { return; } //ignores the combobox default value 
            foreach (var series in modelObj[comboSeriesKey])
            {
                comboSeries.Items.Add(series.Name);
            }

        }


        string comboSeriesKey = "";
        string comboBrandKey = "";

        private void comboSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboModel.Items.Clear();
            comboModel.Text = "Select Model";

            comboSeriesKey = (comboSeries.SelectedItem.ToString());
            comboBrandKey = ((KeyValuePair<string, string>)comboBrand.SelectedItem).Key;

            foreach (var model in modelObj[comboBrandKey][comboSeriesKey])
            {
                comboModel.Items.Add(model.Name);
            }
        }

        private void comboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearTabInfo();
            string comboBrandValue = ((KeyValuePair<string, string>)comboBrand.SelectedItem).Value;
            string comboModelSelected = comboModel.SelectedItem.ToString();
            string prettyName = comboBrandValue + " " + comboModelSelected;

            getDeviceInfo(prettyName);
        }

        //Reading from Catalogv2 XML file to populate Device Tab Info
        String firstMT = "";
        public void getDeviceInfo(string prettyName)
        {
           
            rtbModel.Text += prettyName + ",   ";
            foreach (XmlNode node in doc.DocumentElement)
            {
                string attr = node.Attributes["name"]?.InnerText;
                if (attr == prettyName)
                {
                    foreach (XmlNode chldNode in node.ChildNodes)
                    {
                        if (chldNode.Name == "Types")
                        {
                            foreach (XmlNode chld in chldNode.ChildNodes)
                            {
                                checkedListBoxMT.Items.Add(chld.InnerText);
                                firstMT = checkedListBoxMT.Items[0].ToString();
                            }
                        }
                        if (chldNode.Name == "BIOS")
                        {
                            string biosVersion = chldNode.Attributes["version"]?.Value;
                            string biosCode = chldNode.Attributes["image"]?.Value;
                            string biosExe = chldNode.InnerText;
                            string biosReadme = Path.ChangeExtension(biosExe, ".txt");

                            buvLabel.Text = biosVersion;
                            bcLabel.Text = biosCode;
                            bexeLabel.Text = biosExe;
                            bReadmeLink.Text = biosReadme;
                        }
                        if (chldNode.Name == "SCCM")
                        {
                            string sccmOs = chldNode.Attributes["os"]?.Value;
                            string sccmVersion = chldNode.Attributes["version"]?.Value;
                            DataGridViewSCCM.Rows.Add(sccmOs, sccmVersion, chldNode.InnerText);
                        }
                        if (chldNode.Name == "HSA")
                        {
                            hsaListBox.Items.Add(chldNode.InnerText);
                        }
                    }


                }

            }

        }

        public void clearTabInfo()
        {
            //labels automatically overwrite 
            rtbModel.Clear();
            checkedListBoxMT.Items.Clear();
            bcLabel.Text = "";
            buvLabel.Text = "";
            bexeLabel.Text = "";
            bReadmeLink.Text = "";
            DataGridView1.Rows.Clear();
            DataGridViewSCCM.Rows.Clear();
            hsaListBox.Items.Clear();
            statusStrip1.Items.Clear();
        }

        public void clearSearchCriteria()
        {
            comboBrand.SelectedIndex = 0;
            comboSeries.Items.Clear();
            comboModel.Items.Clear();
        }


        private void comboMT_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearTabInfo();
            clearSearchCriteria();
            comboBiosCode.Text = "";
            comboPackageID.Text = "";
            comboTitle.Text = "";

            var mt = comboMT.Text.ToUpper();
            //comboMT.Text = mt;
            if (mt.Length == 4)
            {
                tabs.SelectedTab = tabDevice;
                fillMtDetails(mt);
               
                //add the itmes to combobox here? or add them in ProcessCatalog()?
                if (!comboMT.Items.Contains(mt))
                {
                    comboMT.Items.Add(mt); 
                }
              /*   if(osVersion != null)
                {
                    if (backgroundWorker1.IsBusy != true)
                    {
                        // Start the asynchronous operation.
                        backgroundWorker1.RunWorkerAsync(comboMT.Text.ToUpper()); //pass function here
                        //ProcessCatalog(comboMT.Text.ToUpper());
                    }
                }*/
            }
            

        }

        public void fillMtDetails(string mt)
        {
            foreach (XmlNode node in doc.DocumentElement)
            {
                foreach (XmlNode chldNode in node.ChildNodes)
                {
                    if (chldNode.Name == "Types")
                    {
                        foreach (XmlNode chld in chldNode.ChildNodes)
                        {
                            if (chld.InnerText == mt)
                            {
                                var prettyName = chldNode.ParentNode.Attributes["name"].Value;
                                getDeviceInfo(prettyName);
                            }
                           
                        }
                    }
                }
            }
            
        }

        private void comboBiosCode_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            clearTabInfo();
            clearSearchCriteria();
            comboMT.Text = "";
            comboPackageID.Text = "";
            comboTitle.Text = "";

            var bc = comboBiosCode.Text;
            if (bc.Length == 4)
            {
                tabs.SelectedTab = tabDevice;
                fillBiosDetails(bc);

                if (!comboBiosCode.Items.Contains(bc))
                {
                    comboBiosCode.Items.Add(bc);
                }
               /* if (osVersion != null)
                 {
                     if (backgroundWorker1.IsBusy != true)
                     {
                         backgroundWorker1.RunWorkerAsync(firstMT); 
                     }
                     //ProcessCatalog(firstMT);
                 }*/
            }
        }

        public void fillBiosDetails(string bc)
        {
            foreach (XmlNode node in doc.DocumentElement)
            {
                foreach (XmlNode chldNode in node.ChildNodes)
                {
                    if (chldNode.Name == "BIOS")
                    {
                        string biosCode = chldNode.Attributes["image"]?.Value;
                        if (biosCode == bc)
                        {
                            var prettyName = chldNode.ParentNode.Attributes["name"].Value;
                            getDeviceInfo(prettyName);
                        }

                    }
                }
            }
        }

        private void comboTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioWin10.Checked || radioWin11.Checked && comboTitle.Text != null && comboMT.Text != null)
            {
                foreach (System.Windows.Forms.DataGridViewRow r in DataGridView1.Rows)
                {
                    if ((r.Cells["Title"].Value).ToString().ToUpper().Contains(comboTitle.Text.ToUpper()))
                    {
                        DataGridView1.Rows[r.Index].Visible = true;
                        DataGridView1.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        DataGridView1.CurrentCell = null;
                        DataGridView1.Rows[r.Index].Visible = false;
                    }
                }

            }
            else { MessageBox.Show("Select a machine type and OS"); }
        }



        private void comboPackageID_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearTabInfo();
            clearSearchCriteria();
            //comboBiosCode.SelectedIndex = -1;
            comboBiosCode.Text = "";
            //comboMT.SelectedIndex = -1;
            comboMT.Text = "";
            //comboTitle.SelectedIndex = -1;
            comboTitle.Text = "";

            var pID = comboPackageID.Text;
            if (pID.Length > 10)
            {
                if (!pID.Contains("_2_.xml"))
                {
                    pID = pID + "_2_.xml";
                }
                if (!comboPackageID.Items.Contains(pID))
                {
                    comboPackageID.Items.Add(pID);
                }
                ProcessPackage(pID);
                //If packageID matched then add it to the dropdown list

            }

        }

        private void checkedListBoxMT_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < checkedListBoxMT.Items.Count; ++i)
            {
                //only allows one checkbox to be checked 
                if (i == e.Index)
                {
                    checkedListBoxMT.SetItemChecked(i, false);

                    comboMT.Text = checkedListBoxMT.Text;

                    if (!comboMT.Items.Contains(checkedListBoxMT.Text))
                    {
                        comboMT.Items.Add(checkedListBoxMT.Text);

                    }
                    else { continue; }
                }
            }
            DataGridView1.Rows.Clear();
           /* if (osVersion != null)
            {
                
                if (backgroundWorker1.IsBusy != true)
                {
                    // Start the asynchronous operation.
                    backgroundWorker1.RunWorkerAsync(comboMT.Text.ToUpper()); //pass function here
                                                                              //ProcessCatalog(comboMT.Text.ToUpper());
                }
                //ProcessCatalog(comboMT.Text.ToUpper());
            }*/

        }


        public void DataGridViewSCCM_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewSCCM.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if (shiftPressed == false)
                {
                    var clickedLink = DataGridViewSCCM.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    Process.Start(clickedLink);
                }
                else
                {
                    var clickedLink = DataGridViewSCCM.CurrentCell.Value.ToString();
                    string clickedReadme = Path.ChangeExtension(clickedLink, ".txt");
                    Process.Start(clickedReadme);
                }

            }

        }

        private void DataGridViewSCCM_KeyDown(object sender, KeyEventArgs e)
        {

            if (Control.ModifierKeys == Keys.Shift)
            {
                shiftPressed = true;
            }
        }
        private void DataGridViewSCCM_KeyUp(object sender, KeyEventArgs e)
        {
            shiftPressed = false;
        }


        private void os_CheckedChange(object sender, EventArgs e)
        {
            var osRadioButton = panelRadio.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            osVersion = osRadioButton.Text;


            if (comboModel.SelectedIndex != 0 && comboModel.SelectedIndex != -1 && comboModel.Text != "Select Model")
            {
                comboModel_SelectedIndexChanged(sender, e);
            }

            if (comboMT.Text != "" || comboMT.SelectedIndex != -1)
            {
                comboMT_SelectedIndexChanged(sender, e);
                MessageBox.Show(comboMT.Text);
            }
            if (comboBiosCode.Text != "" || comboBiosCode.SelectedIndex != -1)
            {
                comboBiosCode_SelectedIndexChanged_1(sender, e);
                MessageBox.Show(comboBiosCode.Text);
            }
            if (comboPackageID.Text != "" || comboPackageID.SelectedIndex != -1)
            {
                comboPackageID_SelectedIndexChanged(sender, e);
            }
            // MessageBox.Show(osVersion); //it loops twice (fix this)
        }

        /// <summary>
        /// /////////////////////////////////////////////// Catalog Details Tab //////////////////////////////////////////////////////////
        /// </summary>









        private void ProcessCatalog(string mt)
        {
         
            try
            {
                String OS_suffix = osVersion;

                string file_to_download = mt + "_" + OS_suffix + ".xml";
                string desc_to_download = mt + "_" + OS_suffix + "_DESC.xml";

                
                _Downloader = new WebFileDownloader(); //could put this into workerreport/progressreported percentage
               
                if (_Downloader.DownloadFileWithProgress(catalog_base_pathX + desc_to_download + "?t=" + DateTime.Now.Ticks.ToString(), local_base_path + desc_to_download))
                {
                    //backgroundWorker1.ReportProgress();
                   // MessageBox.Show("Line499");
                    toolStripStatusLabel1.Text = "Downloading catalog: " + catalog_base_pathX + file_to_download;
                    toolStripStatusLabel2.Text = "To: " + local_base_path + file_to_download;

                    if (_Downloader.DownloadFileWithProgress(catalog_base_pathX + file_to_download + "?t=" + DateTime.Now.Ticks.ToString(), local_base_path + file_to_download))
                    {
                        string expectedCRC = getCatalogCRC(local_base_path + desc_to_download).ToLower();
                        //this.setStatus("Expected CRC: " + expectedCRC);

                        string actualCRC = getSHA256hash(local_base_path + file_to_download).ToLower();
                        //this.setStatus("Actual CRC: " + actualCRC);

                        if ((expectedCRC ?? "") == (actualCRC ?? ""))
                        {
                            //this.setStatus("CRCs Match!!");
                            statusLabel1.Text = "CRCs Match!!";
                        }
                        else
                        {
                            MessageBox.Show("** CRCs DO NOT MATCH!! **");
                            toolStripStatusLabel1.Text = "** CRCs DO NOT MATCH!! **";
                        }
                       // MessageBox.Show("Line522");
                        var pkgNameList = new List<string>();
                        List<_package> pkgsList = getPackages(local_base_path + file_to_download);
                        var pkgNameListDL = new List<string>();
                        if (pkgsList != null)
                        {
                            MessageBox.Show("Line528");
                            // Loop through and add pkg to DataGridView1
                            foreach (_package pkg in pkgsList)
                            {
                                this.DataGridView1.Rows.Add(pkg.CPkgID, pkg.CPackageName, pkg.CTitle, pkg.CVersion, pkg.CReleased, pkg.CPackageType, pkg.CCategory, pkg.CReboot, pkg.CSeverity, pkg.CBrand, pkg.Csetup, pkg.Clangs, pkg.Cxml2valid, pkg.CURLxml2, pkg.Cxml2crc, pkg.Cxml2crcactual);
                               // MessageBox.Show("Line533");
                                if (pkgNameList.Contains(pkg.CPackageName))
                                {
                                 //   MessageBox.Show("Line536");
                                    if (!pkgNameListDL.Contains(pkg.CPackageName))
                                    {
                                        pkgNameListDL.Add(pkg.CPackageName);
                                   //     MessageBox.Show("Line539");
                                    }
                                }
                                else
                                {
                                    //MessageBox.Show("Line545");
                                    pkgNameList.Add(pkg.CPackageName);
                                }

                            }
                           // MessageBox.Show("Line547");
                            if (pkgNameListDL.Count > 0)
                            {
                                foreach (string z in pkgNameListDL)
                                {
                                    foreach (_package y in pkgsList)
                                    {
                                        if (z == y.CPackageName)
                                        {
                                            downlevelPackages.Add(y.CPkgID + "\t" + y.CPackageName + "\t" + y.CReleased + "\t" + "https://download.lenovo.com/catalog/" + comboModel.SelectedItem + "_" + osVersion + ".xml" + "\t" + y.CURLxml2);
                                           // MessageBox.Show("Line557");
                                        }
                                    }
                                }
                            }
                        }
                       // MessageBox.Show("Line559");
                        setColumns();
                        //MessageBox.Show("Line561");
                        this.DataGridView1.AutoResizeColumns();
                        this.DataGridView1.Sort(DataGridView1.Columns["Valid"], System.ComponentModel.ListSortDirection.Ascending);
                        //this.SetBGColor(); //error here if valid == 0
                        toolStripStatusLabel1.Text = "Got all packages";

                    }

                    else
                    {
                        //this.setStatus("Could not download catalog.");
                        toolStripStatusLabel1.Text = "Could not download catalog.";

                        string expectedCRC = getCatalogCRC(local_base_path + desc_to_download).ToLower();
                        //this.setStatus("Expected CRC: " + expectedCRC);
                        toolStripStatusLabel2.Text = "Expected CRC: " + expectedCRC;

                        string actualCRC = getSHA256hash(local_base_path + file_to_download).ToLower();
                        //this.setStatus("Actual CRC: " + actualCRC);
                        toolStripStatusLabel3.Text = "Actual CRC: " + actualCRC;
                        //MessageBox.Show("line 506");

                        if ((expectedCRC ?? "") == (actualCRC ?? ""))
                        {
                            //this.setStatus("CRCs Match!!");
                            toolStripStatusLabel1.Text = "CRCs Match!!";

                        }
                        else
                        {
                            //this.setStatus("** CRCs DO NOT MATCH!! **");
                            toolStripStatusLabel1.Text = "** CRCs DO NOT MATCH!! **";
                        }

                        List<_package> pkgsList = getPackages(local_base_path + file_to_download);
                        if (pkgsList != null)
                        {
                            // Loop through and add pkg to DataGridView1
                            foreach (_package pkg in pkgsList)
                                this.DataGridView1.Rows.Add(pkg.CPkgID, pkg.CPackageName, pkg.CTitle, pkg.CVersion, pkg.CReleased, pkg.CPackageType, pkg.CCategory, pkg.CReboot, pkg.CSeverity, pkg.CBrand, pkg.Csetup, pkg.Clangs, pkg.Cxml2valid, pkg.CURLxml2, pkg.Cxml2crc, pkg.Cxml2crcactual);
                        }
                        this.DataGridView1.AutoResizeColumns();
                        //this.setStatus("Got all packages.");
                        toolStripStatusLabel1.Text = "Got all packages.";
                    }
                   // MessageBox.Show("Line605");
                }
                else
                {
                    //this.setStatus("Could not download catalog descriptor.");
                    MessageBox.Show("Could not download catalog descriptor.");
                }
               // MessageBox.Show("Line613");
            }

            catch (Exception ex)
            {
                MessageBox.Show("ProcessCatalog: " + ex.Message.ToString());
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
                    var locationValue = m_node.ChildNodes.Item(0).InnerText;

                    // Get the checksum Element Value
                    var crcValue = m_node.ChildNodes.Item(1).InnerText;

                    return crcValue;
                }
                return "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return "";
            }
        }

        //#region Catalog Handlers
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

                //this.setStatus("Total packages (" + catalog.Substring(catalog.LastIndexOf(@"\") + 1) + "): " + m_nodelist.Count.ToString);
                //this.setStatus("Getting details for packages, please wait...");
                toolStripStatusLabel1.Text = "Total packages (" + catalog.Substring(catalog.LastIndexOf(@"\") + 1) + "): " + m_nodelist.Count.ToString();
                toolStripStatusLabel2.Text = "Getting details for packages, please wait...";

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


        private void setColumns()
        {
            try
            {
                this.DataGridView1.Columns["PkgID"].Visible = this.cbPackageID.Checked;
                this.DataGridView1.Columns["PackageName"].Visible = this.cbPackageName.Checked;
                this.DataGridView1.Columns["Title"].Visible = this.cbTitle.Checked;
                this.DataGridView1.Columns["Version"].Visible = this.cbVersion.Checked;
                this.DataGridView1.Columns["Released"].Visible = this.cbReleased.Checked;
                this.DataGridView1.Columns["PackageType"].Visible = this.cbPackageType.Checked;
                this.DataGridView1.Columns["category"].Visible = this.cbCategory.Checked;
                this.DataGridView1.Columns["RebootType"].Visible = this.cbReboot.Checked;
                this.DataGridView1.Columns["Severity"].Visible = this.cbSeverity.Checked;
                this.DataGridView1.Columns["Brand"].Visible = this.cbBrand.Checked;
                this.DataGridView1.Columns["Setup"].Visible = this.cbSetup.Checked;
                this.DataGridView1.Columns["language"].Visible = this.cbLanguage.Checked;
                this.DataGridView1.Columns["Valid"].Visible = this.cbValid.Checked;
                this.DataGridView1.Columns["xml2_path"].Visible = this.cbXML2Path.Checked;
                this.DataGridView1.Columns["CRC"].Visible = this.cbCRC_Catalog.Checked;
                this.DataGridView1.Columns["crcactual"].Visible = this.cbCRC_Actual.Checked;
                this.DataGridView1.Columns["Comment"].Visible = this.cbComment.Checked;
            }
            catch (Exception ex)
            {
                // Handle the exception
            }
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


                if (cnt == 0) { continue; }
                else
                { //error on line 723
                    if (DataGridView1.Rows[cnt].Cells["Valid"].Value.ToString() != "yes") //error here because no "valid" value for datagrid on 20fc

                        DataGridView1.Rows[cnt].DefaultCellStyle.BackColor = Color.LightGray;
                    DataGridView1.Rows[cnt].DefaultCellStyle.ForeColor = Color.Blue;
                    cnt--;
                }
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
                thisPkg.CPackageName = m_nodelist[0].Attributes["name"].Value;
                thisPkg.CVersion = m_nodelist[0].Attributes["version"].Value;

                //thisPkg.CPackageName = m_nodelist.Item(0).Attributes.ItemOf("name").Value;
                //thisPkg.CVersion = m_nodelist.Item(0).Attributes.ItemOf("version").Value;

                // Get the Title node and pull text for <Desc> child node
                m_nodelist = m_xmld.SelectNodes("/Package/Title");
                thisPkg.CTitle = m_nodelist.Item(0).ChildNodes.Item(0).InnerText;

                // Get the ReleaseDate node and pull innertext
                m_nodelist = m_xmld.SelectNodes("/Package/ReleaseDate");
                thisPkg.CReleased = DateTime.Parse(m_nodelist[0].InnerText);
                //thisPkg.CReleased = m_nodelist.Item(0).InnerText;

                // Get the PackageType node and pull "type" attribute
                m_nodelist = m_xmld.SelectNodes("/Package/PackageType");
                int packageType = int.Parse(m_nodelist.Item(0).Attributes["type"].Value);
                switch (packageType)
                {
                    case 1:
                        {
                            thisPkg.CPackageType = "1|Application";
                            break;
                        }
                    case 2:
                        {
                            thisPkg.CPackageType = "2|Driver";
                            break;
                        }
                    case 3:
                        {
                            thisPkg.CPackageType = "3|BIOS";
                            break;
                        }
                    case 4:
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
                int severityType = int.Parse(m_nodelist.Item(0).Attributes["type"].Value);
                switch (severityType)
                {
                    case 1:
                        {
                            thisPkg.CSeverity = "1|Critical";
                            break;
                        }
                    case 2:
                        {
                            thisPkg.CSeverity = "2|Recommended";
                            break;
                        }
                    case 3:
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
                switch (severityType)
                {
                    case 1:
                        {
                            thisPkg.CBrand = "1|All";
                            break;
                        }
                    case 2:
                        {
                            thisPkg.CBrand = "2|Think";
                            break;
                        }
                    case 3:
                        {
                            thisPkg.CBrand = "3|Lenovo Notebook";
                            break;
                        }
                    case 4:
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
                switch (severityType)
                {
                    case 0:
                        {
                            thisPkg.CReboot = "0|No Reboot Required";
                            break;
                        }
                    case 1:
                        {
                            thisPkg.CReboot = "1|Forces Reboot";
                            break;
                        }
                    case 2:
                        {
                            thisPkg.CReboot = "2|Reserved";
                            break;
                        }
                    case 3:
                        {
                            thisPkg.CReboot = "3|Requires a Reboot";
                            break;
                        }
                    case 4:
                        {
                            thisPkg.CReboot = "4|Forces Shutdown";
                            break;
                        }
                    case 5:
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
                if (m_nodelist.Count == 0) { return; } //if nodelist is empty, return it and continue. This causes error if not here (Ex: Readme is empty on some files)
                else
                {
                    _Downloader = new WebFileDownloader();
                    if (_Downloader.DownloadFileWithProgress(thisPkg.CURLxml2.Substring(0, thisPkg.CURLxml2.LastIndexOf("/") + 1) + m_nodelist.Item(0).ChildNodes.Item(0).InnerText + "?t=" + DateTime.Now.Ticks.ToString(), local_base_path + m_nodelist.Item(0).ChildNodes.Item(0).InnerText))
                    {
                        thisPkg.CURLtxt = thisPkg.CURLxml2.Substring(0, thisPkg.CURLxml2.LastIndexOf("/") + 1) + m_nodelist.Item(0).ChildNodes.Item(0).InnerText;
                    }
                }
                if (File.Exists(local_base_path + thisPkg.CPkgID + "_2_.xml"))
                {
                    thisPkg.Cxml2crcactual = getSHA256hash(local_base_path + thisPkg.CPkgID + "_2_.xml").ToLower();
                    if (thisPkg.Cxml2crc == thisPkg.Cxml2crcactual)
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
                // setStatus("getTitle: " + ex.Message.ToString());
                statusLabel1.Text = "getTitle: " + ex.Message.ToString();

            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count == 1)
            {
                this.btnCheckCRC.Enabled = true;
                this.btnClearCatalog.Enabled = true;
            }
            else
            {
                this.btnCheckCRC.Enabled = false;
                this.btnClearCatalog.Enabled = false;
            }
        }


        private void btnCheckCRC_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DataGridView1.SelectedRows[0];
            string xmlURL = row.Cells["xml2_path"].Value.ToString();
            ProcessPackage("", xmlURL);
        }

        private void ProcessPackage(string pkgid, string xmlUrl = "")
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string found = "";
                bool search = false;
                if (string.IsNullOrEmpty(xmlUrl) && !string.IsNullOrEmpty(pkgid))
                {
                    search = true;
                    string file_mobiles = package_base_path + "mobiles/" + pkgid;
                    string file_thinkcentre = package_base_path + "thinkcentre_drivers/" + pkgid;
                    string file_tvt = package_base_path + "thinkvantage_en/" + pkgid;
                    string file_thinkcentre_bios = package_base_path + "thinkcentre_bios/" + pkgid;
                    string file_thinkcentre_sw = package_base_path + "thinkcentre_software/" + pkgid;
                    string file_options = package_base_path + "options/" + pkgid;

                    //setStatus("Searching for package: " + pkgid);
                    statusLabel1.Text = "Searching for package: " + pkgid;
                    //MessageBox.Show("Searching for package: " + pkgid);
                    toolStripStatusLabel1.Text = "Searching for package: " + pkgid;

                    WebFileDownloader _Downloader = new WebFileDownloader();
                    if (_Downloader.DownloadFileWithProgress(file_mobiles + "?t=" + DateTime.Now.Ticks.ToString(), local_base_path + pkgid))
                        found = file_mobiles;
                    if (_Downloader.DownloadFileWithProgress(file_thinkcentre + "?t=" + DateTime.Now.Ticks.ToString(), local_base_path + pkgid))
                        found = file_thinkcentre;
                    if (_Downloader.DownloadFileWithProgress(file_tvt + "?t=" + DateTime.Now.Ticks.ToString(), local_base_path + pkgid))
                        found = file_tvt;
                    if (_Downloader.DownloadFileWithProgress(file_thinkcentre_bios + "?t=" + DateTime.Now.Ticks.ToString(), local_base_path + pkgid))
                        found = file_thinkcentre_bios;
                    if (_Downloader.DownloadFileWithProgress(file_thinkcentre_sw + "?t=" + DateTime.Now.Ticks.ToString(), local_base_path + pkgid))
                        found = file_thinkcentre_sw;
                    if (_Downloader.DownloadFileWithProgress(file_options + "?t=" + DateTime.Now.Ticks.ToString(), local_base_path + pkgid))
                        found = file_options;
                }
                else if (string.IsNullOrEmpty(pkgid) && !string.IsNullOrEmpty(xmlUrl))
                {
                    search = false;
                    found = xmlUrl;
                }

                if (!string.IsNullOrEmpty(found) && search)
                {
                    toolStripStatusLabel1.Text = "Found package: " + found;

                    Process.Start(found);
                    string exeFileName = "";
                    if (checkExe(found, ref exeFileName))
                    {
                        toolStripStatusLabel1.Text = "Installer CRC valid: " + exeFileName;
                    }
                    else
                    {
                        //setStatus("** INSTALLER (" + exeFileName + ") CRC INVALID!!! **");
                        toolStripStatusLabel1.Text = "** INSTALLER (" + exeFileName + ") CRC INVALID!!! **";
                    }
                }
                else if (!string.IsNullOrEmpty(found) && !search)
                {
                    string exeFileName = "";
                    if (checkExe(found, ref exeFileName))
                    {
                        MessageBox.Show("CRC check of the executable file(s), " + exeFileName + ", passed.", "CRC is valid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("** CRC check of the executable file(s), " + exeFileName + ", failed!!! **", "Invalid CRC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // setStatus("Package not found!");
                    MessageBox.Show("Package not found!");
                }
                this.Cursor = Cursors.Arrow;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ProcessPackage: " + ex.Message);
            }
        }

        public bool checkExe(string xmlUrl, [Optional] ref string exeRef) //or ", ref string exeRef" = null instead of [optional]
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
                //this.setStatus("checkExe: " + ex.Message.ToString());
                MessageBox.Show("checkExe: " + ex.Message.ToString());
                return false;
            }

            return default;
        }

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


        private void cbPackageID_CheckedChanged_1(object sender, EventArgs e)
        {
            setColumns();
        }

        private void cbPackageName_CheckedChanged(object sender, EventArgs e)
        {
            setColumns();
        }

        private void cbTitle_CheckedChanged(object sender, EventArgs e)
        {
            setColumns();
        }

        private void cbVersion_CheckedChanged(object sender, EventArgs e)
        {
            setColumns();
        }

        private void cbReleased_CheckedChanged(object sender, EventArgs e)
        {
            setColumns();
        }

        private void cbPackageType_CheckedChanged(object sender, EventArgs e)
        {
            setColumns();
        }

        private void cbCategory_CheckedChanged(object sender, EventArgs e)
        {
            setColumns();
        }

        private void cbBrand_CheckedChanged(object sender, EventArgs e)
        {
            setColumns();
        }

        private void cbSetup_CheckedChanged(object sender, EventArgs e)
        {
            setColumns();
        }

        private void cbValid_CheckedChanged(object sender, EventArgs e)
        {
            setColumns();
        }

        private void cbXML2Path_CheckedChanged(object sender, EventArgs e)
        {
            setColumns();
        }

        private void cbCRC_Catalog_CheckedChanged(object sender, EventArgs e)
        {
            setColumns();
        }

        private void cbCRC_Actual_CheckedChanged(object sender, EventArgs e)
        {
            setColumns();
        }

        private void cbComment_CheckedChanged(object sender, EventArgs e)
        {
            setColumns();
        }

        private void cbSeverity_CheckedChanged(object sender, EventArgs e)
        {
            setColumns();
        }

        private void cbReboot_CheckedChanged(object sender, EventArgs e)
        {
            setColumns();
        }

        private void cbLanguage_CheckedChanged(object sender, EventArgs e)
        {
            setColumns();
        }



        private void pcSupportLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://pcsupport.lenovo.com");
            Process.Start(sInfo);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://psref.lenovo.com");
            Process.Start(sInfo);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://download.lenovo.com/bsco/index.html");
            Process.Start(sInfo);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://docs.lenovocdrt.com");
            Process.Start(sInfo);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://blog.lenovocdrt.com");
            Process.Start(sInfo);
        }

     

        private void btnClearCatalog_Click(object sender, EventArgs e)
        {
            DataGridView1.Rows.Clear();
        }

        private void tabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
           if (e.TabPage == tabCatalog)
            {
                //MessageBox.Show("Clicked catalog tab");
                // if (backgroundWorker1.IsBusy != true)
                //{
                // Start the asynchronous operation.
                progressBar1.Visible = true;

                if (comboMT.Text != "" || comboMT.SelectedIndex != -1)
                {
                    MessageBox.Show("reading comboMT");
                    backgroundWorker1.RunWorkerAsync(comboMT.Text.ToUpper());
                }
                if (comboBiosCode.Text != "" || comboBiosCode.SelectedIndex != -1)
                {
                    MessageBox.Show("reading comboBios");
                    backgroundWorker1.RunWorkerAsync(firstMT);
                }
                // }

            }
            else
            {
                progressBar1.Visible = false; 
            }
           
        }

       
    }
}
