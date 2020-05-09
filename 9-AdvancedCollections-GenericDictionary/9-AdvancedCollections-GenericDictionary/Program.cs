using System;
using System.Collections.Generic;

namespace _9_AdvancedCollections_GenericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating 
            Dictionary<string, string> countries = new Dictionary<string, string>();

            // Creating with initialization
            Dictionary<int, string> names = new Dictionary<int, string>()
            {

                {1, "James" },
                {2, "Charles" },
                {3, "John" }

            };

            // Add
            countries.Add("MEX","Mexico");
            countries.Add("CAD", "Canada");
            countries.Add("USA", "United States");
            countries.Add("BR", "Brazil");



            // Displaying

            foreach (var item in names)
            {
                Console.WriteLine(item.Value);
            }

            foreach (var item in countries)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            for (int i = 0; i < countries.Count; i++)
            {
                Console.WriteLine(countries["MEX"]);
            }
            // TryGetValue
            countries.TryGetValue("MEX",out string result);
            Console.WriteLine("result is: "+result);

            // Remove
            countries.Remove("USA");

            // Count
            Console.WriteLine(countries.Count);

            // Contains
            Console.WriteLine(countries.ContainsKey("USA"));

        }
    }
}
