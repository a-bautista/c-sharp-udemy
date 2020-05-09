using System;

namespace _17_AdvancedCollections_NestedValueTuples
{
    class Program
    {
        static void Main(string[] args)
        {

            // This feature (Value Tuples) belongs to C# 7
            var ronaldoGoals = (Year2018:50, Year2017:40, Year2016:35, Year2015:30);
            var ronaldo = (playerNo: 7, playerName: "Ronaldo", playerGoals: ronaldoGoals);

            var giggs = (10, "Giggs", 40);

            Console.WriteLine(ronaldo.playerNo);
            Console.WriteLine(ronaldo.playerName);
            Console.WriteLine(ronaldo.playerGoals.Year2015);
            Console.WriteLine(ronaldo.playerGoals.Year2016);
            Console.WriteLine(ronaldo.playerGoals.Year2017);
            Console.WriteLine(ronaldo.playerGoals.Year2018);

            DisplayPlayerInformation(giggs);

        }

        public static void DisplayPlayerInformation((int playerNo, string playerName, int playerGoal) player)
        {
            Console.WriteLine("Display the information of this function:\n");
            Console.WriteLine(player.playerNo);
            Console.WriteLine(player.playerName);
            Console.WriteLine(player.playerGoal);
        }
    }
}
