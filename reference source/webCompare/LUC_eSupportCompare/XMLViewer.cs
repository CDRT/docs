using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace LUC_eSupportCompare
{
    public partial class XMLViewer : Form
    {
        public XMLViewer()
        {
            InitializeComponent();
        }

        public void addXML(string xml)
        {
            richTextBox1.Text = PrettyXml(xml);            
        }

        static string PrettyXml(string xml)
        {
            var stringBuilder = new StringBuilder();

            var element = XElement.Parse(xml);

            var settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.Indent = true;
            settings.NewLineOnAttributes = false;

            using (var xmlWriter = XmlWriter.Create(stringBuilder, settings))
            {
                element.Save(xmlWriter);
            }

            return stringBuilder.ToString();
        }
        static string Tabs(int n)
        {
            return "\n" + new String('\t', n);
        }
    }
}
