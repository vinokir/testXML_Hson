using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testXML_JSON
{
    public class data
    {
        public string name;
        public string title;
        public List<sublayer> sublayyers;
    }

    public class sublayer
    {
        public string name;
        public string title;
        public List<attributes> attributes;

    }
    public class attributes
    {
        public string name;
        public string type;
    }
}
