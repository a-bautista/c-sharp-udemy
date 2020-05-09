using System;

namespace PredicateDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> condition = IsAdmin;
            Console.WriteLine(condition(11)); 

        }

        public static bool IsAdmin(int empNumber)
        {
            if (empNumber == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
