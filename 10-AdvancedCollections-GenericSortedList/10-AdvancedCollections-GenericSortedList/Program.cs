using System;
using System.Collections;
using System.Collections.Generic;

namespace _10_AdvancedCollections_GenericSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating
            SortedList list = new SortedList(); // non-generic sortedlist
            SortedList<string,string> phoneBook = new SortedList<string, string>(); // generic sortedlist

            // Adding
            phoneBook.Add("Jack","123456789");
            phoneBook.Add("Johannes", "1234554321");
            phoneBook.Add("Bernard", "0987654321");

            // Displaying

            foreach (var item in phoneBook)
            {
                Console.WriteLine(item.Key + " his/her mobile number is: "+item.Value);
            }

            // Index
            phoneBook["Jack"] = "5555500000";

            // TryGet Value
            phoneBook.TryGetValue("Jack",out string number);

            Console.WriteLine(number);

            // Remove 
            phoneBook.Remove("Bernard");

            foreach (var item in phoneBook)
            {
                Console.WriteLine(item.Key + " his/her phone number is: " +item.Value);
            }

            // Contains
            Console.WriteLine(phoneBook.ContainsKey("Jack"));
        }
    }
}
