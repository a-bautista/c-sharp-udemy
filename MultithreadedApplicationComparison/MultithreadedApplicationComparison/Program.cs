using System;
using System.Threading;

namespace MultithreadedApplicationComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(delegate ()
            {
                Console.WriteLine("Process 1 started");
                Console.WriteLine("Process 1 is running");
                for (long i = 0; i < 2_500_000_000; i++)
                {

                }
                Console.WriteLine("Process 1 has been completed\n");
            }));
            t1.Start();

            Thread t2 = new Thread(new ThreadStart(delegate ()
            {
                Console.WriteLine("Process 2 started");
                Console.WriteLine("Process 2 is running");
                for (long i = 0; i < 5_000_000_000; i++)
                {

                }
                Console.WriteLine("Process 2 has been completed\n");
            }));
            t2.Start();
        }
    }
}
