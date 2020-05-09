using System;
using System.Threading;

namespace ParameterizedThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper();
            Thread t1 = new Thread(new ParameterizedThreadStart(helper.Loop));
            Thread t2 = new Thread(new ParameterizedThreadStart(helper.Loop));
            Console.WriteLine("Initializing thread 1");
            t1.Start(500);
            Console.WriteLine("Initializing thread 2");
            t2.Start(1000);
        }
    }

    class Helper
    {
        public void Loop(object number)
        {
            for (int i = 0; i < int.Parse(number.ToString()); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
