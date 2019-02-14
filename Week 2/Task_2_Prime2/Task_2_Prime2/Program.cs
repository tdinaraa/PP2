using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Prime2
{
    class Program
    {
        static bool isPrime(int num) //функция для проверки на простоту числа
        {
            if (num == 1)
                return false; 
            for (int i = 2; i * i <= num; i++) 
                if (num%i==0) //если число делится на i без остатка, то оно не простое
                    return false; 
            return true; 
        }

        static void Main(string[] args)
        {
            FileStream ifs = new FileStream(@"C:\Users\ASUS\Desktop\github\Week 2\inp.txt", FileMode.Open, FileAccess.Read); //класс используемый для файловых данных
            StreamReader sr = new StreamReader(ifs); //StreamReader считывает содержимое файла

            string s = sr.ReadLine(); //новая переменная считывает данные с sr
            string[] arr = s.Split(); //массив, разделяющий данные с s

            sr.Close();
            ifs.Close();

            FileStream ofs = new FileStream(@"C:\Users\ASUS\Desktop\github\Week 2\out.txt", FileMode.Open, FileAccess.Write); //в новый файловый документ пишется результат
            StreamWriter sr2 = new StreamWriter (ofs);

            for (int i=0; i<arr.Length; i++)
            {
                int x = int.Parse(arr[i]);
                if (isPrime(x)) //если число простое, оно записывается во второй текстовый файл
                {
                    sr2.Write(x + " ");
                }
            }

            sr2.Close();
            ofs.Close();
        }
    }
}
