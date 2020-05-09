using System;
using System.Collections.Specialized;

namespace _14_AdvancedCollections_NameValueCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating
            NameValueCollection cities = new NameValueCollection();

            // Adding
            cities.Add("Germany", "Berlin");
            cities.Add("Germany", "Dresden");
            cities.Add("Germany", "Hannover");
            cities.Add("Italy", "Rome");
            cities.Add("Italy", "Sicily");

            // Displaying
            foreach (string item in cities)
            {
                Console.Write(item + ": ");
                Console.WriteLine(cities[item]);
            }

            // Set
            cities.Set("Italy", "Milan");
            foreach (string item in cities)
            {
                Console.Write(item + ": ");
                Console.WriteLine(cities[item]);
            }

            // Contains
            Console.WriteLine(cities.HasKeys());
            cities.Clear();

            // Remove
            cities.Remove("Germany");
            
        }
    }
}
