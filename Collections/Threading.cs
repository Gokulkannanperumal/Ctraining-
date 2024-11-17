using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;//threading namespace
using System.Threading.Tasks;

namespace Collections
{
    public class Threading
    {
        public void Thread1(object state)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name+" : "+i);
                Thread.Sleep(1000);
                
            }
        }
        public void Thread2(object state)
        {
            // Queue a task to the ThreadPool
        }
         void DoWork(object state)
        {
            Console.WriteLine("Background thread started.");
            Thread.Sleep(2000);  // Simulating work
            Console.WriteLine("Background thread ends.");
        }


        public void invokerthread()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(Thread1));
            ThreadPool.QueueUserWorkItem(new WaitCallback(DoWork));
            ThreadPool.QueueUserWorkItem(new WaitCallback(Thread2));

            Console.WriteLine("Main thread is doing other work...");
            Thread.Sleep(3000);  // Simulating other work

            Console.WriteLine("Main thread ends.");
        }
    }
}
