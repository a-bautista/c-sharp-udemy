using System;

namespace GenericDelegateTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> funcOne = AddNumbers;
            Console.WriteLine(AddNumbers(2, 4));

            Func<int> funcTwo = AddNumbers;
            Console.WriteLine(funcTwo());

            // Generic Action version
            Action<int> actionOne = DisplayInformation;
            actionOne(10);

            // Non-generic Action version
            Action actionTwo = DisplayInformation;
            actionTwo();

            Predicate<int> predicateOne = IsAdmin;
            Console.WriteLine(predicateOne(10)); 
        }

        public static bool IsAdmin(int empNumber)
        {
            if (empNumber < 0)
                return false;
            else
                return true; 
        }

        public static void DisplayInformation()
        {
            int number = 200;
            Console.WriteLine("This is my number: "+number);
        }

        public static void DisplayInformation(int number)
        {
            Console.WriteLine("This is my number: "+number);
        }

        public static int AddNumbers(int x, int z)
        {
            return x + z;
        }

        public static int AddNumbers()
        {
            int x = 10;
            int y = 15;
            int z = 0;

            z = x + y;
            return z;
        }
    }
}
