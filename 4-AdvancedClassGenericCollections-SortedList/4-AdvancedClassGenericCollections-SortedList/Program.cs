using System;
using System.Collections;

namespace _4_AdvancedClassGenericCollections_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating
            SortedList sortedList = new SortedList();

            // Adding values
            sortedList.Add(1, "January");
            sortedList.Add(2, "February");
            sortedList.Add(3, "March");
            sortedList.Add(4, "April");
            sortedList.Add(5, "May");

            // Displaying values

            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine(sortedList.GetKey(i) + ":" + sortedList.GetByIndex(i));
            }

            // Index
            Console.WriteLine(sortedList[2].ToString());

            // Capacity
            Console.WriteLine("Total elements inside:\n");
            Console.WriteLine(sortedList.Count);

            // Remove
            sortedList.RemoveAt(0);
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            // Contains
            Console.WriteLine(sortedList.ContainsValue("May"));

            // Copy to ArrayList
            ArrayList array = new ArrayList(sortedList.Values);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}
