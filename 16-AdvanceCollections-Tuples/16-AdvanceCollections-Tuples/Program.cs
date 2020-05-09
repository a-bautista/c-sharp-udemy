﻿using System;

namespace _16_AdvanceCollections_Tuples
{
    class Program
    {
        static void Main(string[] args)
        {

            
            (int playerno, string name) ronaldo = (7, "Ronaldo");
            Console.WriteLine(ronaldo.name);

            var aria = Tuple.Create(12, "Aria", "Stark", "Winterfell");
            DisplayInformation(aria);
            var sansa = Tuple.Create(18, "Sansa", "Stark", "Winterfell");
            Console.WriteLine("----------------");
            Console.WriteLine(GetInformation().Item1);
            Console.WriteLine(GetInformation().Item2);
            Console.WriteLine(GetInformation().Item3);
            Console.WriteLine(GetInformation().Item4);
        }

        public static void DisplayInformation(Tuple<int, string, string, string> personInfo)
        {
            Console.WriteLine(personInfo.Item1);
            Console.WriteLine(personInfo.Item2);
            Console.WriteLine(personInfo.Item3);
            Console.WriteLine(personInfo.Item4);
        }

        public static Tuple <int, string, string, string> GetInformation()
        {
            var info = Tuple.Create(25, "Rob", "Stark", "Winterfell");
            return info;
        }
    }
}
