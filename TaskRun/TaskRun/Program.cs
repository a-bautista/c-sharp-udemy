using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskRun
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHiTask();
            Console.ReadLine();
            AddNumbersTask(10, 30, 40);
        }
        private static Task SayHiTask()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Hello from the task!");
            });      
        }

        public static Task AddNumbersTask(params int[] numbers)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Add numbers task started...");
                int result = 0;
                foreach (var number in numbers)
                {
                    result += number;

                }
                Console.WriteLine("Total = " + result);
            });
        }
    }
}
