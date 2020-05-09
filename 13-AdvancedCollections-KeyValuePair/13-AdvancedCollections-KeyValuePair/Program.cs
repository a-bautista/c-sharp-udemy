using System;
using System.Collections.Generic;

namespace _13_AdvancedCollections_KeyValuePair
{
    class Program
    {
        static void Main(string[] args)
        {
            var capitals = new List<KeyValuePair<string, string>>();

            capitals.Add(new KeyValuePair<string, string>("Russia", "Moscow"));
            capitals.Add(new KeyValuePair<string, string>("Mexico", "Mexico City"));
            capitals.Add(new KeyValuePair<string, string>("Germany", "Berlin"));

            foreach (var item in capitals)
            {
                Console.WriteLine(item.Key);

            }

            Console.WriteLine(GetFirstAndLastName().Key);
        }

        public static KeyValuePair<string, string> GetFirstAndLastName()
        {
            string firstName = "Bruce";
            string lastName = "Wayne";
            return new KeyValuePair<string, string>(firstName, lastName);
        }
    }
}
