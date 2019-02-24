using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mark_list_serialization_deserialization
{
    [Serializable]
    class ListSerial
    {
        public ListSerial ()
        {

        }
        
        public static void xsSave(List<Mark> points) //новое название
        {
            FileStream fs = new FileStream("res.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));
            xs.Serialize(fs, points);
            fs.Close();
        }

        public static List<Mark> xsLoad() //why ne void
        {
            FileStream fs = new FileStream("res.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));
            List<Mark> m = xs.Deserialize(fs) as List<Mark>;
            fs.Close();
            return m;
        }
    }
}
