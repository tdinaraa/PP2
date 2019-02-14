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
        static string path = @"C:\Users\ASUS\Desktop\c++"; //используемый путь

        static void Main(string[] args)
        {
            Show(path, 0); //путь, отступ
        }

        static void Show(string path, int x)
        {
            DirectoryInfo d = new DirectoryInfo(@path); //все папки берутся с указанного пути 
            FileSystemInfo[] fsi = d.GetFileSystemInfos(); //массив, содержащий все папки и файлы
            string s = new string(' ', x); //новая переменная для указания отступов


            for (int i = 0; i < fsi.Length; i++) 
            {
                FileSystemInfo fs = fsi[i]; 

                if (fs.GetType() == typeof(FileInfo)) //если тип объекта файл, цвет текста меняется на Cyan
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else //если объект является папкой, его цвет меняется на желтый
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; 
                }

                Console.WriteLine(s + fs.Name); //выводятся имена всех объектов


                if (fs.GetType() == typeof(DirectoryInfo))
                {
                    Show(@fs.FullName, x + 3); //если выбранный объект является папкой, мы заходим во внутрь папки с указанным отступом
                }

            }
        }

    }
}
