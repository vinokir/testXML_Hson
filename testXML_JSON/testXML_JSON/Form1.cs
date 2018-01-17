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
                XDocument doc = XDocument.Parse(XML_textBox.Text);
                Logic log = new Logic();
                JSON_textBox.Text = log.GetJson(doc);
            }
            catch (System.Xml.XmlException ex)
            {
                 MessageBox.Show(ex.Message);
            }
        }
    }
}
