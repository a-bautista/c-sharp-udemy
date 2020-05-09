using System;
using System.Collections.Generic;

namespace _12_AdvancedCollections_GenericQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<DateTime> arrivals = new Queue<DateTime>();
            arrivals.Enqueue(new DateTime(2018,01,01));
            arrivals.Enqueue(new DateTime(2019, 01, 01));
            arrivals.Enqueue(new DateTime(2020, 01, 01));

            foreach (var item in arrivals)
            {
                Console.WriteLine(item);
            }

            arrivals.Dequeue();

            foreach (var item in arrivals)
            {
                Console.WriteLine(item);
            }
        }
    }
}
