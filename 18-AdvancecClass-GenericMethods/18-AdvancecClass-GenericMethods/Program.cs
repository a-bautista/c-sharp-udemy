using System;

namespace _18_AdvancecClass_GenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Display(2.0);
            Display("This is a generic method!");
            var tupleValue = (1, "Berlin", "Germany");
            Display(tupleValue);
        }

        public static void Display<T>(T info)
        {
            Console.WriteLine(info);
        }
    }
}
