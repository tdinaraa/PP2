using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Compex_number_serialize_deserialize
{
    [Serializable]
    public class Numbers
    {
        [XmlElement]
        public int a, b;

        public Numbers()
        {

        }

        public Numbers(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void ShowInfo()
        {
            Console.WriteLine(a + "+" + b+"i");
        }

        public void Save()
        {
            FileStream fs = new FileStream("res.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Numbers));
            xs.Serialize(fs, this);
            fs.Close();
        }


        public static Numbers Load()
        {
            FileStream fs = new FileStream("res.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Numbers));
            Numbers num = xs.Deserialize(fs) as Numbers;
            fs.Close();
            return num;
        }
    }

    class Program
    {       
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Numbers n = new Numbers(a, b);
            
            n.Save();

            Numbers n2=Numbers.Load();
            n2.ShowInfo();
        }
    }
}

