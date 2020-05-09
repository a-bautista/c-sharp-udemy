using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourName = "";
            string tvSeriesName = "The Simpsons";
            string tvSeriesNameSpaces = " The Simpsons ";
            string season = "Season 31";

            // Indexes - 
            Console.WriteLine(tvSeriesName[0]);

            //How to loop through each letter? Use length
            for (int i=0; i<tvSeriesName.Length; i++)
            {
                Console.WriteLine(tvSeriesName[i]);
            }
            // Trim
            Console.WriteLine(tvSeriesNameSpaces.Trim());

            // Upper Case
            Console.WriteLine(tvSeriesName.ToUpper());

            // Lower Case
            Console.WriteLine(tvSeriesName.ToLower());

            // Replace
            Console.WriteLine(tvSeriesNameSpaces.Replace(" ","*"));

            // IndexOf
            Console.WriteLine(tvSeriesName.IndexOf('o'));

            // Substring
            Console.WriteLine(tvSeriesName.Substring(0, 3));

            // Substring - This one takes from the index 0 until the end
            Console.WriteLine(tvSeriesName.Substring(4));

            // Remove - This one takes from index 0 until 4
            Console.WriteLine(tvSeriesName.Remove(4));

            // Insert
            Console.WriteLine(tvSeriesName.Insert(tvSeriesName.Length, " Inserted"));

            //Console.WriteLine(tvSeriesName.Insert(season.Trim(),season));

            // Escape characters
            Console.WriteLine("And John Said \"Over here \t \a \" ");

            Console.WriteLine("What's your name?");
            yourName = Console.ReadLine();

            // Make the first letter of your name in UpperCase (manually)
            string firstLetter = yourName.Substring(0,1).ToUpper();
            yourName = yourName.Replace(yourName.Substring(0,1), firstLetter);

            //String interpolation
            Console.WriteLine($"Welcome back again {yourName}");

            int numberOne = 10;
            int numberTwo = 20;
            int z = 0;
            double x = 6.2;
            int[] numbers = new int[5] { 1, 10, 100, 1000, 10000};
            string[] weekdays = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday",
                                "Saturday", "Sunday"};
            

            Random rand = new Random();

            Console.WriteLine(Math.Ceiling(x));
            Console.WriteLine(Math.Floor(x));
            Console.WriteLine(Math.Round(x, 0));
            Console.WriteLine(Math.Truncate(x));
            Console.WriteLine("The max value of these two numbers is: "+ Math.Max(numberOne, numberTwo));
            Console.WriteLine("The min value of these two numbers is: " + Math.Min(numberOne, numberTwo));

            z = rand.Next(1,70);
            Console.WriteLine("The random generated number is "+ z);


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


            foreach (var day in weekdays)
            {
                Console.WriteLine(day);
            }
        }

    }
}
