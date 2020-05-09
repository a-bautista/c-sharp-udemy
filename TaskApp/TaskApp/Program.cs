using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task taskOne = new Task(new Action(SayHi));
            Task taskTwo = new Task(delegate ()
            {
                Console.WriteLine("Task 2 is starting");
                Console.WriteLine("Task 2 is running");
                Console.WriteLine("Hey there!");
                Thread.Sleep(10000);
                Console.WriteLine("Task 2 is complete!");
            });
            Task taskThree = new Task(() =>
            {
                Console.WriteLine("Task 3 is starting");
                Console.WriteLine("Task 3 is running");
                Console.WriteLine("Hey there!");
                Thread.Sleep(10000);
                Console.WriteLine("Task 3 is complete!");
            });

            taskOne.Start();
            taskTwo.Start();
            taskThree.Start();

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Welcome back " + name);
      
        }

        public static void SayHi()
        {
            Console.WriteLine("Task is starting");
            Console.WriteLine("Task is running");
            Console.WriteLine("Hey there!");
            Thread.Sleep(10000);
            Console.WriteLine("Task is complete!");
        }
    }
}
