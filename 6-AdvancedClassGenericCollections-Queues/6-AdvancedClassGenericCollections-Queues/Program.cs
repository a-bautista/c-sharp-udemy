using System;
using System.Collections;

namespace _6_AdvancedClassGenericCollections_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            // Adding
            queue.Enqueue("Marvin");
            queue.Enqueue("Aston");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Removing

            queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
