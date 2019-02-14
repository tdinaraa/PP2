using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1_Polindrome
{
    class Program
    {
        static void Solve(string str) //функция для проверки на полиндром
        {
            bool ok = true;

            for (int i = 0; i < str.Length; ++i)
            {
                if (str[str.Length - 1 - i] != str[i]) //если последний элемент не равен первому, предпоследний второму итд
                {
                    ok = false; //текст не полнидром
                    break;
                }
            }

            if (ok)
            {
                Console.WriteLine("Yes"); //если текст полиндром, выодится текст "Yes"
            }
            else
            {
                Console.WriteLine("No"); //если текст не полиндром, выодится текст "No"
            }
        }

        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\ASUS\Desktop\github\Week 2\fortask1.txt", FileMode.Open, FileAccess.Read); //класс используемый для файловых данных
            StreamReader sr = new StreamReader(fs); //StreamReader считывает содержимое файла

            string line = sr.ReadLine(); //переменная, которая хранит содержимое файла

            Solve(line); //используется метод Solve

            sr.Close();
            fs.Close();
        }
    }
}
