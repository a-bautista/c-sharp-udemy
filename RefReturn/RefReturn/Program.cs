using System;

namespace RefReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 3;
            ref int x2 = ref x1;

            Console.WriteLine(x1);
            Console.WriteLine(x2);

            ref var returnValue = ref ReturnByReference();
            Console.WriteLine(returnValue);


        }

        public static ref string ReturnByReference()
        {
            string[] arrayOfNames = { "Ella", "Jessica", "Claire" };
            return ref arrayOfNames[0];
        }
    }
}
