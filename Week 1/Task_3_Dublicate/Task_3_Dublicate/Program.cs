using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Dublicate
{
    class Program
    {
        static int[] Dublicate(int[] arr) //method (function) of new array
        {
            int[] arr2 = new int[1000]; //creating the second array, that consists dublicated numbers
            for (int i = 0; i < arr.Length; i++) //cycle that works until the length of array
            {
                arr2[i * 2] = arr[i];
                arr2[i * 2 + 1] = arr[i]; //new array stores duplicated elements of the first array
                //ex: arr2[0]=arr[0], arr2[2]=arr[1], arr2[4]=arr[2]...
                //    arr2[1]=arr[0], arr2[3]=arr[1], arr2[5]=arr[2]...
            }

            return arr2; //arr2 is returned
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //int n enetered as the amount of numbers that will exist
            string[] s = Console.ReadLine().Split(); //array of string is readed by Console
            int[] arr = new int[n]; //array that consists elements

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(s[i]); //string is converted to int
            }

            int[] arr2 = Dublicate(arr); //new array uses "Dublicate" function
            for (int i = 0; i < n * 2; i++) //cycle works until two times of lenght of enetered number n
            {
                Console.Write(arr2[i] + " "); //Console executes elements of new array
            }
        }
    }
}