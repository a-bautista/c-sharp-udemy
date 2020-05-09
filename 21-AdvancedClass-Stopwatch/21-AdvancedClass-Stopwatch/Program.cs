using System;
using System.Diagnostics;

namespace _21_AdvancedClass_Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Loop(900_000_000);
            watch.Stop();

            Console.WriteLine("Miliseconds: "+watch.ElapsedMilliseconds);
            Console.WriteLine("Total miliseconds: " + watch.Elapsed.TotalMilliseconds);
            Console.WriteLine("Total seconds: " + watch.Elapsed.TotalSeconds);
            Console.WriteLine("Total ticks: "+watch.ElapsedTicks);
        }

        public static void Loop(long number)
        {
            for (int i = 0; i < number; i++)
            {

            }
            Console.WriteLine("Process done!");
        }
    }
}
