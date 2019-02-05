using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_3_DirectoryFileInfos
{
    class Program
    {
        static string path = @"C:\Users\ASUS\Desktop\c++"; //neccessary path

        static void Main(string[] args)
        {
            Show(path, 0); //path and indent
        }

        static void Show(string path, int x)
        {
            DirectoryInfo d = new DirectoryInfo(@path); //path of Directory
            FileSystemInfo[] fsi = d.GetFileSystemInfos(); //Array that reads Directories and Files
            string s = new string(' ', x);


            for (int i = 0; i < fsi.Length; i++) 
            {
                FileSystemInfo fs = fsi[i];

                if (fs.GetType() == typeof(FileInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan; //Files are painted to the Cyan color
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; //Directories are painted to the Yellow color
                }

                Console.WriteLine(s + fs.Name); //All names are printed


                if (fs.GetType() == typeof(DirectoryInfo))
                {
                    Show(@fs.FullName, x + 3); //if it is a Directory Files, we go to the inside of folder with indent
                }

            }
        }

    }
}
