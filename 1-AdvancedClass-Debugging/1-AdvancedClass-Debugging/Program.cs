using System;
using System.Diagnostics;

namespace _1_AdvancedClass_Debugging
{
    class Program
    {
        static int x = 0;
        static int y = 0;
        // What's the difference between step over and step into?
        // step into goes step by step while step over doesn't display that much info
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            Debug.WriteLine("Hello from the debug line!");
            Debug.WriteLine("x =" + x);
            Debug.WriteLine("y =" + y);
            Debug.WriteLineIf(x < 50, "This value is less than 50");

            x = 2;
            y = 2;
            Console.WriteLine("Inside of the main!");
            ChangeValues();
            x = 8;
            y = 8;
            Console.WriteLine("Inside of the main method again.");
        }

        public static void ChangeValues()
        {
            x = 4;
            y = 4;
            Console.WriteLine("Inside the change values method.");
        }
    }
}
