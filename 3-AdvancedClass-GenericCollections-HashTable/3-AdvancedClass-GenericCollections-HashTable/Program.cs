using System;
using System.Collections;

namespace _3_AdvancedClass_GenericCollections_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating
            Hashtable hash = new Hashtable();

            // Adding values
            hash.Add("Amazon", "USA");
            hash.Add("Age", 45);
            hash.Add(1, "100");


            // Displaying values
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            // Capacity
            Console.WriteLine("The total number of items is: " +hash.Count);


            // Remove
            hash.Remove(1);

            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            // Contains
            if (hash.ContainsKey(("Amazon")))
            {
                Console.WriteLine("Key was found!");
            }

            // Copy ArrayList: You can copy keys or values but not both

            ArrayList arrayList = new ArrayList(hash.Keys);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
