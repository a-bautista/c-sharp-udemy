using System;
using System.Collections.Generic;

namespace YieldKeyworkd
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in PerformMathOperations(2,5))
            {
                Console.WriteLine(item);
            }
        }
        public static IEnumerable<double> PerformMathOperations(int number1, int number2)
        {
            yield return number1 + number2;
            yield return number1 - number2;
            yield return number1 * number2;
            yield return Math.Round((double) number1 / (double) number2);
        }
    }
}
