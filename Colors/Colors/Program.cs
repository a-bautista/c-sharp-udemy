using System;

namespace Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            string greenMessage = "This is your text in green!";
            string blueMessage  = "This is your text in blue!";
            string redMessage   = "This is your text in red!";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(greenMessage);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(blueMessage);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(redMessage);
            Console.ForegroundColor = ConsoleColor.White;
            var distanceToSunFromEarth = 149_600_000;
            Console.WriteLine(distanceToSunFromEarth);

            long longVar = default;
            DateTime datetime = default;

            Console.WriteLine(longVar);
            Console.WriteLine(datetime);
        }
    }
}
