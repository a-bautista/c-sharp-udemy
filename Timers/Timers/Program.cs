using System;
using System.Timers;

namespace Timers
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.Elapsed += OnEachSecond;
            timer.Interval = 5000;
            timer.Enabled = true;
            Console.WriteLine("Press x to exit.");
            while (Console.Read() != 'x') ;
            
        }

        private static void OnEachSecond(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Yes, it is working at "+DateTime.Now.ToLongTimeString());
        }
    }
}
