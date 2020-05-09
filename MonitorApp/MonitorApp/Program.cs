using System;
using System.Threading;

namespace MonitorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Files file = new Files();
            Thread[] threads = new Thread[10];

            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(file.Write));
                threads[i].Start($"C:\\Users{i}.txt");
            }
        }
    }

    class Files
    {
        public void Write(object path)
        {
            Monitor.Enter(path); // ONLY access to this piece of code one at time
            try
            {
                Console.WriteLine("Writing in " + path);
                Thread.Sleep(2000);
                Console.WriteLine("Writing process has been completed.");
            }
            finally
            {
                Monitor.Exit(path);
            }
        }
        public void Read(object path)
        {
            Console.WriteLine("Reading from " + path);
            Thread.Sleep(1000);
            Console.WriteLine("Reading process has been completed\n");
            
        }
    }
}
