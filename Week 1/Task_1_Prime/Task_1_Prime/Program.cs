using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Prime
{
    class Program
    {
        static bool isPrime(int num) //function that checks is the number prime or not
        {
            if (num == 1)
                return false; //number 1 is not prime
            for (int i = 2; i * i <= num; i++) //check other numbers to prime. It must be checked until square root
                if (num % i == 0) //if remainder of the number is equal to 0, when we divide it to i
                    return false; //number is not prime 
            return true; //on the other way, it is prime number
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()); //input the amount of number that will exist
            int sum = 0; //sum is used to calculate the amount of prime numbers
            int[] arr = new int[10000]; //creating the array of numbers
            int[] arr_prime = new int[10000]; //new array that saves prime numbers
            int j = 0; //new variable
            string[] s = Console.ReadLine().Split(); //array s reads all numbers that we enter and split them
            //we used srting, because Console.Readline does not read int

            for (int i = 0; i < num; ++i)
            {
                arr[i] = int.Parse(s[i]); //string is converted to int
                if (isPrime(arr[i]) == true) //if the number is prime
                {
                    sum++; //sum increases
                    arr_prime[j] = arr[i]; //new array of prime numbers is filling
                    j++;
                }
            }
            Console.WriteLine(sum); //Console shows how many prime numbers are exist
            for (int i = 0; i < sum; i++)
                Console.Write(arr_prime[i] + " "); //Console executes all prime numbers
        }
    }
}


