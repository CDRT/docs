using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace investigator
{
    public partial class Form2 : Form
    {
        public string x;
        public string linkpID;

        public Form2(string xml)//string readme, string exe, string xml)
        {
            InitializeComponent();
            x = xml;
        }


        private void downloadReadme_btn_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(x);
            XmlNode node = doc.DocumentElement.SelectSingleNode("./Files/Readme/File/Name");
     
            string link = x;
            int index = link.LastIndexOf("/");
            if (index >= 0)
                link = link.Substring(0, index + 1);
            linkpID = link + node.InnerText;
            var readme = linkpID;
            Process.Start(readme);
        }

        private void downloadExe_btn_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(x);
            XmlNode node = doc.DocumentElement.SelectSingleNode("./Files/Installer/File/Name");

            string link = x;
            int index = link.LastIndexOf("/");
            if (index >= 0)
                link = link.Substring(0, index + 1);
            linkpID = link + node.InnerText;
            var exe = linkpID;
            Process.Start(exe);
        }

        private void downloadXML_btn_Click(object sender, EventArgs e)
        {
            Process.Start(x);
        }
    }
}
