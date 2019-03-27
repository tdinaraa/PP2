using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_lab_task2
{
   public class MyThread
    {
        private Thread thread; //thread is private
        //private int pause; 

        public MyThread (string name /*int pause*/)
        {
            this.thread = new Thread(showNums);
            this.thread.Name = name;
           // this.pause = pause;
        }

        public void startThread()
        {
            this.thread.Start();
        }

        private void showNums()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " shows "+ i);
                //Thread.Sleep(pause);
            }

            Console.WriteLine(Thread.CurrentThread.Name + " ended");
        }
    }
    }

