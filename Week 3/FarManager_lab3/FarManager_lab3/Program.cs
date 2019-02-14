using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarManager_lab3
{
    class Program
    {
        static string path = @"C:\Users\ASUS\Desktop\github\Week 3\ForLab3"; //используемый путь
        static FileSystemInfo currentFSI; //текущий элемент 
        static int selectedindex = 0;
        static Stack<string> hist = new Stack<string>(); //стэк для хранения того или иного пути


        static void Show()
        {
            Console.SetCursorPosition(0, 0); //каждый раз позиция курсора 0,0 при запуске функции Show
            DirectoryInfo d = new DirectoryInfo(@path); //все папки берутся с указанного пути

            List<FileSystemInfo> li = new List<FileSystemInfo>(); //List используется для вывода сначала папок, затем файлов
            li.AddRange(d.GetDirectories());
            li.AddRange(d.GetFiles());
            FileSystemInfo[] fsi = li.ToArray();
            currentFSI = fsi[selectedindex];

            for (int i = 0; i < fsi.Length; i++)
            {
                FileSystemInfo fs = fsi[i];
                if (selectedindex == i) //выбранный элемент закрашен в красный цвет
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else //фон остальных элементов черный
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                if (fs.GetType() == typeof(DirectoryInfo)) //если тип объекта папка, цвет текста меняется на белый цвет
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else //если тип объекта файл, цвет текста меняется на желтый
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.WriteLine(i+1 + ". " + fs.Name); //консоль выводит нумерацию и имя объекта
            }
        }

        static void Main(string[] args)
        {

            while (true) //цикл бесконечный
            {
                Show(); //запускается функция Show
                ConsoleKeyInfo cki = Console.ReadKey(); //перменная для работы с клавишами
                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow: //при нажатия следующих клавиш, выполняются соответстующие функции
                        UpArrow();
                        break;
                    case ConsoleKey.DownArrow:
                        DownArrow();
                        break;
                    case ConsoleKey.Enter:
                        OpenFile();
                        break;
                    case ConsoleKey.Escape:
                        Escape();
                        break;
                    case ConsoleKey.Delete:
                        Delete();
                        break;
                    case ConsoleKey.R:
                        Rename();
                        break;                 
                }

            }
        }

        static void UpArrow() //функция для клавиши UpArrow
        {
            selectedindex--; //выбранный индекс уменьшается
            if (selectedindex < 0)
            {
                selectedindex = 0;
            }
        }

        static void DownArrow() //функция для клавиши DownArrow
        {
            selectedindex++; //выбранный индекс увеличивается
        }

        static void OpenFile() //функция для клавиши Enter
        {
            Console.Clear();

            if (currentFSI.GetType() == typeof(DirectoryInfo)) //если текущий элемент, это папка
            {
                selectedindex = 0; //индекс приравнивается к нулю
                hist.Push(path); //стэк заходит во внутрь папки
                path = currentFSI.FullName; //пусть приравнивается новому пути 
                Console.Clear();
            }
            else //если текущий элемент, это файл
            {
                FileStream fs = new FileStream(currentFSI.FullName, FileMode.Open, FileAccess.Read); //класс используемый для работы с файловыми данными (путь=выбранный файл)
                StreamReader sr = new StreamReader(fs); //StreamReader считывает содержимое файла
                Console.WriteLine(sr.ReadToEnd()); //консоль выводит все содержимое файла от начала до конца
                Console.ReadKey();     
                sr.Close();
                fs.Close();
            }
            Console.Clear();
        }

        static void Escape () //функция для клавиши Escape
        {
            path = hist.Peek(); //путь последней папки, show запустится из родительской папки
            hist.Pop(); //удаляем
            selectedindex = 0; //выбранный индекс приравнивается к нулю
            Console.Clear();
        }

        static void Delete () //функция для клавиши Delete
        {
            if (currentFSI.GetType()==typeof(FileInfo)) //если выбранный объект файл, его путь полностью удаляется
            {
                File.Delete(currentFSI.FullName);
            }
            else //если выбранный объект папка, его путь полностью удаляется
            {
                Directory.Delete(currentFSI.FullName, true); //true-означает удаление не пустых папок тоже
            }
            Console.Clear();
            selectedindex = 0;
        }

        static void Rename () //функция для клавиши Rename
        {
            Console.SetCursorPosition(10, 30); //снизу консоля выводится следующий текст
            Console.Write("Enter new name:");
            string path = currentFSI.FullName; //путь->путь выбранного объекта
            string pr = new DirectoryInfo(path).Parent.FullName; //pr->переменная, которая берет путь до название объекта
            string newName = Console.ReadLine();

            if (currentFSI.GetType() == typeof(FileInfo)) //если выбранный объект файл, ему присваивается новое имя
            {
                File.Move(path, pr + "\\" + newName);
            }
            else //если выбранный объект папка, ему также присваивается новое заданное имя
            {
                Directory.Move(path, pr + "\\" + newName);
            }

            Console.Clear();

        }

    }
}
