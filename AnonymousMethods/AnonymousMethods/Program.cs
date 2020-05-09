using System;

namespace AnonymousMethods
{
    delegate void DisplayInfo();
    delegate void DisplayInfoBasedOnNumber(int number);
    class Program
    {
        static void Main(string[] args)
        {
            DisplayInfo normalDelegate = new DisplayInfo(GetInformation);

            DisplayInfoBasedOnNumber oneParameterDelegate = new DisplayInfoBasedOnNumber(GetInformation);
            oneParameterDelegate(100);

            DisplayInfo normalDelegateAnonymous = delegate { Console.WriteLine("Hi from the anonymous method"); };
            normalDelegateAnonymous();

            DisplayInfoBasedOnNumber oneParameterDelegateAnonymous = delegate (int number)
            { Console.WriteLine("Hi from the anonymous method which takes one int parameter" + number); };
            oneParameterDelegate(150);
            
        }

        public static void GetInformation()
        {
            Console.WriteLine("Delegate with no parameter");
        }

        public static void GetInformation(int x)
        {
            Console.WriteLine("Delegate with one parameter: "+x);
        }
    }
}
