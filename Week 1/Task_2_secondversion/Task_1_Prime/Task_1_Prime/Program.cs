using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Prime
{
    class Program
    {
        static bool isPrime(int num) //функция, проверяющая число на простоту
        {
            if (num == 1)
                return false; 
            for (int i = 2; i * i <= num; i++) 
                if (num % i == 0) //если остаток числа от деления на i ровно нулю, число не простое
                    return false; 
            return true; 
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()); //консоль читает число, которое вводится
            int sum = 0; //сумма нужна для подсчета простых чисел в ряду
            int[] arr = new int[10000]; //массив чисел
            int[] arr_prime = new int[10000]; //массив, хранящий ряд простых чисел
            int j = 0; 
            string[] s = Console.ReadLine().Split(); //массив, считывающий все внесенные числа, и он также разделяет числа между собой

            for (int i = 0; i < num; ++i)
            {
                arr[i] = int.Parse(s[i]); //string переводится в int
                if (isPrime(arr[i]) == true) //если число простое, сумма увеличивется и записывается в новый массив
                {
                    sum++; 
                    arr_prime[j] = arr[i]; 
                    j++;
                }
            }

            Console.WriteLine(sum); //консоль выводит количество простых чисел
            for (int i = 0; i < sum; i++)
                Console.Write(arr_prime[i] + " "); //консоль выводит все простые числа
        }
    }
}


