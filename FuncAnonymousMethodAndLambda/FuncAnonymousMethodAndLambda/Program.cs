using System;

namespace FuncAnonymousMethodAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Func
            string name = "Alejandro Bautista Ramos";
            Console.WriteLine("using func");
            Console.WriteLine(UpperCaseString(name));

            //Anonymous method
            Func<string, string> anonymousMethod = delegate (string myName) { return myName; };
            Console.WriteLine("using anonymous method");
            Console.WriteLine(anonymousMethod(name));

            // Lambda expresion
            Func<string, string> lambdaExpression = text => text.ToUpper();
            Console.WriteLine("using lambda expression");
            Console.WriteLine(lambdaExpression(name));

            
        }
        public static string UpperCaseString(string inputString)
        {
            return inputString.ToUpper();
        }
    }
}
