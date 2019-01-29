using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublicate_numbers_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //Console read the number that we will enter as an amount
            int[] arr = new int[10000]; //creat an array
            string[] s = Console.ReadLine().Split(); //create an array of s and console read it

            for (int i = 0; i < n; ++i) //double loop is created
            {
                for (int j = 0; j < 2; ++j)//it will work until a number will be repeated two times
                {
                    arr[i] = int.Parse(s[i]); //array of string is converted to int
                    Console.Write(arr[i] + " "); //Console shows elements of array
                }
            }
        }
    }

}
