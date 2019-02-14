using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //консоль считывает число

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++) //используется двойной массив
                {
                    if (j <= i) 
                        Console.Write("[*]"); //консоль выводит [*]
                }
                Console.WriteLine(); 

            }
        }
    }
}
