using System;

namespace DelegatesMulticast
{
    public delegate void SayHiDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            SayHiDelegate sayHi = null;
            sayHi  = new SayHiDelegate(SayHiEnglish);
            sayHi += new SayHiDelegate(SayHiSpanish);
            sayHi += new SayHiDelegate(SayHiFrench);
            sayHi();
        }

        public static void SayHiEnglish()
        {
            Console.WriteLine("Hi there!");
        }

        public static void SayHiSpanish()
        {
            Console.WriteLine("Hola");
        }

        public static void SayHiFrench()
        {
            Console.WriteLine("Salut");
        }
    }
}
