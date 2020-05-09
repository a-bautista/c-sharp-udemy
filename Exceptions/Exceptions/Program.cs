using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            double dividend = 0;
            double divisor  = 0;
            double result   = 0;

            try
            {
                Console.WriteLine("Enter the divisor number:");
                divisor = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the dividend number:");
                dividend = int.Parse(Console.ReadLine());

                result = dividend / divisor;
                Console.WriteLine($"This is your result {result}");
            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine("Division by zero error! Would not proceed.");
            }
            catch (FormatException error)
            {
                Console.WriteLine("Invalid input values.");
            }
        }
    }
}
