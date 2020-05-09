using System;

namespace AnonymousMethodLambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Alejandro";

            // Action
            Action<string> Message = ShowMessage;
            Message(name);

            // Anonymous method
            Action<string> anonymousMethod = delegate (string myName) { Console.WriteLine($"Hi, how are you, {myName}"); };
            anonymousMethod(name);

            // Lambda expression
            Action<string> lambdaExpression = x => Console.WriteLine($"hey, how are you, {x}");
            lambdaExpression(name);


        }

        public static void ShowMessage(string name)
        {
            Console.WriteLine($"Hey there! How are you {name}?");
        }
    }
}
