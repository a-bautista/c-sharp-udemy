using System;
using System.Collections.Generic;

namespace _8_AdvancedClassCollections_GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating
            List<string> firstList = new List<string>();

            IList<string> secondList = new List<string>();

            firstList.Add("England");
            firstList.Add("Hungary");
            firstList.Add("China");
            firstList.Add("Germany");

            // Displaying

            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            // Index
            Console.WriteLine(firstList[1]);

            // Capacity
            Console.WriteLine("Count of the generic list is: "+firstList.Count);

            // Sorting
            Console.WriteLine("After sorting: ");
            firstList.Sort();

            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            // Reversing
            Console.WriteLine("After reversing: ");
            firstList.Reverse();
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            // Removing
            Console.WriteLine("After removing");
            firstList.Remove("China");
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            // Contains
            Console.WriteLine(firstList.Contains("Germany"));


            // GetRange
            secondList = firstList.GetRange(0, 2);
            foreach (var item in secondList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
