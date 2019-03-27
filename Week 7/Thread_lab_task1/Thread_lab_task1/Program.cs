using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_lab_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            F1();
        }

        static void F1()
        {
            Thread[] thread = new Thread[3]; //массив из 3 элементов типа Thread

            thread[0] = new Thread(ShowName);
            thread[0].Name = "First";
            thread[0].Start();

            thread[1] = new Thread(ShowName);
            thread[1].Name = "Second";
            thread[1].Start();

            thread[2] = new Thread(ShowName);
            thread[2].Name = "Third";
            thread[2].Start();
        }

        static void ShowName()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);        
                Thread.Sleep(1000);
            }
        }          
    }
}

  
