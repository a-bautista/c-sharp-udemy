using System;
using System.Threading;

namespace SemaphoreApp
{
    class Program
    {
        private static Semaphore semaphore = new Semaphore(2,2);
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread newThread = new Thread(new ThreadStart(delegate ()
                {
                    // number of times the method will be used by each thread
                    for (int d = 0; d < 1; d++)
                    {
                        UseResource();
                    }
                }));

                newThread.Name = String.Format("(Thread no. {0})", i + 1);
                newThread.Start();
            }
        }

        private static void UseResource()
        {
            Console.WriteLine("{0} is requesting the mutex", Thread.CurrentThread.Name);
            semaphore.WaitOne();

            Console.WriteLine("{0} has entered the critical section", Thread.CurrentThread.Name);
            Thread.Sleep(7000);
            Console.WriteLine("{0} is leaving the critical section", Thread.CurrentThread.Name);

            semaphore.Release();
            Console.WriteLine("{0} has released the mutex", Thread.CurrentThread.Name);
        }
    }
}


