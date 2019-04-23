using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mark_list_serialization_deserialization
{
    class Program
    {
        static void Main(string[] args)
        {                  
          List<Mark> marks = ListSerial.xsLoad();

            Mark emark = new Mark(int.Parse(Console.ReadLine()));
            marks.Add(emark);

            foreach (Mark m in marks)
            {
                Console.WriteLine(m.ToString()); //можно не вызывть данную функцию, так как она уже встроена в программу
            }

            ListSerial.xsSave(marks);
            Console.ReadKey();
            
        }

        public static void xsSave(List<Mark> points)
        {
            FileStream fs = new FileStream("res.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));
            xs.Serialize(fs, points);
            fs.Close();
        }

    }
}
