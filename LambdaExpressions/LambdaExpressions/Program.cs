using System;

namespace LambdaExpressions
{
    delegate void DisplayMessage();
    delegate int Multiply(int n);
    class Program
    {
        static void Main(string[] args)
        {
            Multiply MultiplyNumber = n => n * 3;
            Console.WriteLine(MultiplyNumber(20));

            DisplayMessage Message = () => Console.WriteLine("Hi from the lambda expression");
            Message();
        }
    }
}
