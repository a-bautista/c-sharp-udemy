using System;
using System.Collections;

namespace _5_AdvancedClassGenericCollections_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating
            Stack stack = new Stack();

            // Adding
            stack.Push("David"); // last one to be removed
            stack.Push("Orlando");
            stack.Push("Emma");
            stack.Push("Jack"); // first one to be removed

            // Removing
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Count);
        }
    }
}
