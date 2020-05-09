using System;

namespace ExpressionBodiedMembersOrArrowFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Alejandro");
            Console.WriteLine(AddTwoNumbers(5, 10)); 
        }

        public static void SayHi(string name) => Console.WriteLine($"Welcome back {name}");

        public static int AddTwoNumbers(int x, int y) => x + y; // you don't add the return because it is an arrow function
    }
}
