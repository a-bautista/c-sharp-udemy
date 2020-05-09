using System;

namespace ActionDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> actionOne = DisplayInformation;
            actionOne(16);

            Action actionTwo = DisplayInformation;
            actionTwo();
        }

        public static void DisplayInformation(int number)
        {
            Console.WriteLine("Your number is: "+number);
        }

        public static void DisplayInformation()
        {
            Console.WriteLine("Anonymous");
        }
    }
}
