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
        static bool isPrime(int num) 
        {
            if (num == 1)
                return false; 
            for (int i = 2; i * i <= num; i++) 
                if (num%i==0)
                    return false; 
            return true; 
        }
        static void Main(string[] args)
        {
            FileStream ifs = new FileStream(@"C:\Users\ASUS\Desktop\github\Week 2\inp.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(ifs);

            string s = sr.ReadLine();
            string[] arr = s.Split();

            sr.Close();
            ifs.Close();

            FileStream ofs = new FileStream(@"C:\Users\ASUS\Desktop\github\Week 2\out.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sr2 = new StreamWriter (ofs);

            for (int i=0; i<arr.Length; i++)
            {
                int x = int.Parse(arr[i]);
                if (isPrime(x))
                {
                    sr2.Write(x + " ");
                }
            }

            sr2.Close();
            ofs.Close();


        }
    }
}
