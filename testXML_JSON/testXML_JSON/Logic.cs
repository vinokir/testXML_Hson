using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace testXML_JSON
{

    public class Logic
    {
        public string GetJson(XDocument xml)
        {
            string serialized = "";
            foreach (var el in xml.Root.Elements())
            {
                data dat = new data();
                try
                {
                    dat.name = el.Element("Name").Value;
                    dat.title = el.Element("title").Value;
                }
                catch (Exception ex)
                {
                    string err = ex.Message;
                }
                if (dat.title == null) dat.title = "";
                dat.sublayyers = new List<sublayer>();
                foreach (var elem in el.Elements("Layer"))
                {
                    sublayer sub = new sublayer();
                    sub.name = elem.Element("Name").Value;
                    sub.title = elem.Element("Title").Value;
                    sub.attributes = new List<attributes>();
                    var elemen = elem.Elements("Attributes");
                    foreach (var element in elemen.Elements("Attribute"))
                    {
                        attributes attr = new attributes();
                        attr.name = element.Attribute("name").Value;
                        attr.type = element.Attribute("type").Value;
                        sub.attributes.Add(attr);
                    }
                    dat.sublayyers.Add(sub);
                }

                 serialized = JsonConvert.SerializeObject(dat);
            }
            return serialized;
            }
           
        }
    }

