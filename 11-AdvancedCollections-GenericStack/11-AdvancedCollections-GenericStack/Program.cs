using System;
using System.Collections.Generic;

namespace _11_AdvancedCollections_GenericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> Ram = new Stack<string>();

            Ram.Push("Photoshop");
            Ram.Push("Google Chrome");
            Ram.Push("Firefox");

            Console.WriteLine(Ram.Peek());
        }
    }
}
