using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_CreateDelete
{
    class Program
    {
        static void Main(string[] args)
        {
           // File.Delete(@"C:\Users\ASUS\Desktop\github\Week 2\Task4\test2.txt");
            FileStream fs = File.Create(@"C:\Users\ASUS\Desktop\github\Week 2\test1.txt"); //создается файл в указанном пути, с указанным именем
    
            fs.Close();
            File.Copy(@"C:\Users\ASUS\Desktop\github\Week 2\test1.txt", 
                @"C:\Users\ASUS\Desktop\github\Week 2\Task_4_NewFile\test2.txt"); //первый файл копируется во во второй указанный путь с новым именем

            File.Delete(@"C:\Users\ASUS\Desktop\github\Week 2\test1.txt"); //первый файл удаляется
        }
    }
}