using System;
using System.Collections.Generic;

namespace Delegates
{
    // void delegate with no argument
    public delegate void PlayerInfoDelegate();

    // void delegate with one string argument
    public delegate void PlayerInfoWithNameDelegate(string playerName);

    // string delegate with one string argument and int argument
    public delegate void PlayerInfoWithNameAndGoalsDelegate(string playerName, int goals);

    // string delegate with one int argument
    public delegate string PlayerBasedOnNumber(int number);

    // string delegate with one int argument and one string
    public delegate string PlayerInformationBasedOnNumberAndClub(int playerNo, string club, string country = "Unknown");

    // delegate to display the dictionary
    public delegate void DisplayDictionaryContent(Dictionary<int, string> content);


    class Program
    {
        static void Main(string[] args)
        {
            PlayerInfoDelegate messi = new PlayerInfoDelegate(DisplayInformation);

            messi();

            PlayerInfoWithNameDelegate playerName = new PlayerInfoWithNameDelegate(DisplayInformation);
            playerName("ronaldo");

            PlayerInfoWithNameAndGoalsDelegate anotherPlayer = new PlayerInfoWithNameAndGoalsDelegate(DisplayInformation);
            anotherPlayer("Messi", 60);

            PlayerBasedOnNumber newPlayer = new PlayerBasedOnNumber(DisplayInformation);
            Console.WriteLine(newPlayer(10));

            PlayerInformationBasedOnNumberAndClub playerOne = new PlayerInformationBasedOnNumberAndClub(DisplayInformation);
            playerOne(7, "Real Madrid");


            // Create a dictionary that will be used in a delegate
            Dictionary<int, string> listOfItems = new Dictionary<int, string>();
            listOfItems.Add(1,"Item One");
            listOfItems.Add(2, "Item Two");
            listOfItems.Add(3, "Item Three");
            listOfItems.Add(4, "Item Four");
            listOfItems.Add(5, "Item Five");

            DisplayDictionaryContent content = new DisplayDictionaryContent(DisplayDataDictionary);
            content(listOfItems);

        }

        public static void DisplayDataDictionary(Dictionary<int, string> content)
        {
            foreach (var item in content)
            {
                Console.WriteLine("This is the key:"+item.Key+"\nThis is the value: "+item.Value);
            }
        }

        public static void DisplayInformation()
        {
            Console.WriteLine("Information about the player: ");
        }

        public static void DisplayInformation(string playerName)
        {
            Console.WriteLine("Information about the player: " + playerName);
        }

        public static void DisplayInformation(string playerName, int goals)
        {
            Console.WriteLine("Information about the player: "+ playerName + " and he scored " + goals);
        }

        public static string DisplayInformation(int goals)
        {
            
            string playerName = string.Empty;

            switch (goals)
            {
                case 7: playerName = "Ronaldo"; break;
                case 8: playerName = "Iniesta"; break;
                case 10: playerName = "Messi"; break;
                default: break;
            }
            return playerName;

        }

        public static string DisplayInformation(int number, string club, string country = "Unknown")
        {
            Console.WriteLine("Hello!");
            return string.Empty;
        }

    }
}
