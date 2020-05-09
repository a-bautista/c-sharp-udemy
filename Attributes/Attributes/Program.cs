using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.SayHi();
            Person.SayHello();
        }
    }

    class Person
    {
        [Obsolete("This method is not going to be included in the latest versions.")]
        public static void SayHi()
        {

        }

        public static void SayHello()
        {

        }
    }
}
