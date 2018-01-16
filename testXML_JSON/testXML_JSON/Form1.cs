using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Xml;

namespace testXML_JSON
{
    public partial class ConvertXMLtoJson_Form : Form
    {
        public ConvertXMLtoJson_Form()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(XML_textBox.Text);
                string jsonText = JsonConvert.SerializeXmlNode(doc);
                JSON_textBox.Text = jsonText;
            }
            catch (System.Xml.XmlException ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }
    }
}
