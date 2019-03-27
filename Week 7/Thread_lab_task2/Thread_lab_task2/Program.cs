using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_lab_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyThread t1 = new MyThread("Thread 1" /*300*/);
            MyThread t2 = new MyThread("Thread 2" /*600*/);
            MyThread t3 = new MyThread("Thread 3" /*500*/);
            //MyThread t4 = new MyThread("Thread 4");
            //MyThread t5 = new MyThread("Thread 5");

            t1.startThread();
            t2.startThread();
            t3.startThread();


            Console.Read();
        }
    }
}
