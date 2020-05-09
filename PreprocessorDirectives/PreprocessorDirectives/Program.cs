#define underDev
using System;

namespace PreprocessorDirectives
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             #define #if #else #endif #warning #error #pragma warning disable
             */

#if(underDev)
            Console.WriteLine("This app is under development");
#else
            Console.WriteLine("This app is complete!");
#endif
#warning This app is complete and ready to be published
        }
    }
}
