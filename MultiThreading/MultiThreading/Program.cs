using System;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        static Thread threadOne;
        static Thread threadTwo;
        static void Main(string[] args)
        { 
            threadOne = new Thread(new ThreadStart(SayHiEnglish));
            threadTwo =new Thread(new ThreadStart(SayHiSpanish));
            Thread threadAnonymousExpression = new Thread(new ThreadStart(delegate ()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Hello from the Anonymous method.");
                }
            }));

            Thread lambdaExpression = new Thread(new ThreadStart(() => Console.WriteLine("Hello from Lambda expression")));
            threadOne.Name = "Thread number 1 (English)";
            threadTwo.Name = "Thread number 2 (Spanish)";

            threadOne.Start();
            threadTwo.Start();
            threadAnonymousExpression.Start();
            lambdaExpression.Start();
        }

        public static void SayHiEnglish()
        {
            Console.WriteLine("Starting to execute "+Thread.CurrentThread.Name);
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i + "Hello! ");
            }
        }

        public static void SayHiSpanish()
        {
            Console.WriteLine("Starting to execute " + Thread.CurrentThread.Name);
            for (int i = 0; i < 50; i++)
            {
                if (i==30)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "is about to abort.");
                    threadOne.Abort();
                }
                Thread.Sleep(new TimeSpan(0, 0, 1));
                Console.WriteLine(i + "Hola! ");
            }
        }
    }
}
