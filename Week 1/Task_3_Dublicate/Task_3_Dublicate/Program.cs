using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Dublicate
{
    class Program
    {
        static int[] Dublicate(int[] arr) //метод для дублирования массивов
        {
            int[] arr2 = new int[1000]; //второй массив, содержащий дублированные числа
            for (int i = 0; i < arr.Length; i++) 
            {
                arr2[i * 2] = arr[i];
                arr2[i * 2 + 1] = arr[i]; 
                //ex: arr2[0]=arr[0], arr2[2]=arr[1], arr2[4]=arr[2]...
                //    arr2[1]=arr[0], arr2[3]=arr[1], arr2[5]=arr[2]...
            }

            return arr2;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //консоль считывает число (количество элементов)
            string[] s = Console.ReadLine().Split(); //массив, разделяющий числа между собой
            int[] arr = new int[n]; 

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(s[i]); //string переводится в int
            }

            int[] arr2 = Dublicate(arr); //массив использует метод дублирования
            for (int i = 0; i < n * 2; i++) //цикл работате до удвоенной длины               
            {
                Console.Write(arr2[i] + " "); //коносоль выводит элементы нового массива
            }
        }
    }
}