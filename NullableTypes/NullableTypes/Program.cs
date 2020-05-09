using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? myDate = null;
            Console.WriteLine(myDate);

            int? number = null;
            Console.WriteLine(number);
            number = 5;

            int numberTwo =  (int) number;
            numberTwo = 10;

            // null coalesce operator
            // if the number is null then display the value of numberTwo
            Console.WriteLine(number ?? numberTwo);

            string firstName = null;
            string message   = null;
            string lastName = "lastname";


            Console.WriteLine(firstName ?? message ?? lastName);


        }
    }
}
