using System;
using System.Timers;
using System.Threading.Tasks;

namespace TaskRunning
{
    class Program
    {
        static Timer timer;
        static Task task;
        static void Main(string[] args)
        {
            task = new Task(() =>
            {
                for (int i = 0; i < 500; i++)
                {
                    Console.WriteLine(i);
                }
            });
            task.Start();

            timer = new Timer();
            timer.Elapsed += CheckTheTask;
            timer.Interval = 100;
            timer.Enabled = true;

            
            Console.ReadLine();
        }

        private static void CheckTheTask(object sender, ElapsedEventArgs e)
        {
            if (task.Status == TaskStatus.Running)
            {
                Console.WriteLine("Task is running...");
            }
            else if(task.Status == TaskStatus.RanToCompletion){
                Console.WriteLine("Task is complete");
                timer.Enabled = false;
                Console.WriteLine("Type in any key to finalize the program.");
            }
        }
    }
}
