using System;

namespace _20_AdvancedClass_ExtendedMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            string text = "Alejandro";
            Console.WriteLine(x.IsGreater(10));
            Console.WriteLine(text.IsNumber());
        }
    }

    static class MyCustomExtension
    {
        public static bool IsGreater(this int value, int number)
        {
            return value > number;
        }

        public static bool IsNumber(this string text)
        {
            return int.TryParse(text, out int result);
        }
    }
}
