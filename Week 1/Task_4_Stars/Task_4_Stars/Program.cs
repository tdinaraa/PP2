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
            int n = int.Parse(Console.ReadLine()); //int n that shows the number of stars that will be executed

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++) //2d arrays
                {
                    if (j <= i) //if j is lesser or equal to i
                        Console.Write("[*]"); //console shows [*]
                }
                Console.WriteLine(); //[*] executed line by line

            }
        }
    }
}
