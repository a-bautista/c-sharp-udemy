using System;
using System.Collections;

namespace _2_AdvancedClass_GenericCollections_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating
            ArrayList array = new ArrayList();
            ArrayList arrayNames = new ArrayList();

            // Adding
            array.Add("First");
            array.Add("Second");
            array.Add("Third");
            array.Add(7);

            arrayNames.Add("Zeb");
            arrayNames.Add("Charles");
            arrayNames.Add("Prometheus");
            arrayNames.Add("Hugo");

            // Display each element
            Console.WriteLine("------------------");
            Console.WriteLine("Before the insertion");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
       
            array.Insert(3, "Fourth");
            Console.WriteLine("------------------");
            Console.WriteLine("After the insertion");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }



            // Index
            Console.WriteLine($"You have the following element at index 4: {array[4]}");


            // Capacity
            Console.WriteLine(array.Count);

            Console.WriteLine("Array of names not sorted:");
            foreach (var item in arrayNames)
            {
                Console.WriteLine(item);
            }

            // Sorting: all the elements must be of the same type
            arrayNames.Sort();

            Console.WriteLine("Display sorted array of names:");
            foreach (var item in arrayNames)
            {
                Console.WriteLine(item);
            }

            // Reverse

            arrayNames.Reverse();
            Console.WriteLine("Display reverse array of names:");
            foreach (var item in arrayNames)
            {
                Console.WriteLine(item);
            }

            // Remove
            array.Remove("First");
            array.RemoveAt(2);
            array.RemoveRange(0,2);


            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            // Remove all

            // Contains
            Console.WriteLine(arrayNames.Contains("Zeb"));

            //Get Range
            
            arrayNames = arrayNames.GetRange(0,3);
            foreach (var item in arrayNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
