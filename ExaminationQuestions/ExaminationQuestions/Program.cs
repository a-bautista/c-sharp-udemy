using System;

namespace ExaminationQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 8 / 3;
            Console.WriteLine(Math.Round(x, 0));
            int i = 4;
            var bit = new bool[] { true, false };
            Console.Write(bit);
            for (i+= 4; i >= 5; i--)
            {
                Console.Write(Math.Truncate(2.99));
            }
            var z = 4 - 4;
            //var y = 4/z;
            //Console.WriteLine(y);
            ParentMethod();

            int? j = 3;
            int r = 2;
        }

        static void ParentMethod()
        {
            Console.WriteLine("Hi from the parent method");
            ChildMethod();
            void ChildMethod()
            {
                Console.WriteLine("Hi from the child method");
            }
        }
    }

}
