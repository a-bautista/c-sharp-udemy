using System;

namespace _1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int addResult = 0;
            string firstEmployee, secondEmployee, thirdEmployee, fourthEmployee, guestName;
            firstEmployee = "Alejandro Bautista";
            secondEmployee = "Dorothy Watson";
            guestName = string.Empty;

            // Pass by reference with the ref keyword
            Console.WriteLine($"Inside the Main method\n-------\n{firstEmployee} \n{secondEmployee}\n");

            ChangeNames(ref firstEmployee, ref secondEmployee);

            // Print the variables with the updated values
            Console.WriteLine($"Inside the Main method\n-------\n{firstEmployee} \n{secondEmployee}\n");

            ChangeNames2(out thirdEmployee, out fourthEmployee);

            a = 5;
            b = 10;

            Console.WriteLine("Hello World!");
            PerformAddOperation(a, b);
            GetName();

            Console.WriteLine("Hello dear guest, what is your name?");

            guestName = Console.ReadLine();

            if (guestName == string.Empty)
                WelcomeGuest();
            else
                WelcomeGuest(guestName);
            



        }

        static void WelcomeGuest()
        {
            Console.WriteLine("Okay, we hope you enjoy your stay at our hotel.");
        }

        static void WelcomeGuest(string name)
        {
            Console.WriteLine($"Hello {name}, we hope you enjoy your stay at our hotel.");
        }

        static int PerformAdd(int num1, int num2)
        {
            return num1 + num2;
        }

        static double PerformAdd(double num1, double num2)
        {
            return num1 + num2;
        }

        static void PerformAddOperation(int x, int y)
        {
            int addResult = 0;
            addResult = x + y;
            Console.WriteLine($"{x} + {y} = {addResult}" );
        }

        static void GetName()
        {
            string name = string.Empty;
            Console.WriteLine("Type your name: ");
            name = Console.ReadLine();
            SayHi(name);
        }

        static void ChangeNames(ref string firstEmp, ref string secondEmp)
        {
            Console.WriteLine("This method is using the ref keyword.");
            firstEmp  = "Olivia Aaron";
            secondEmp = "Rodrigo Jimenez";
            Console.WriteLine($"Outside Main method\n-------------\n{firstEmp} \n{secondEmp}\n");
        }

        static void ChangeNames2(out string firstEmp, out string secondEmp)
        {
            Console.WriteLine("This method is using the out keyword.");
            firstEmp = "Olivia Aaron";
            secondEmp = "Rodrigo Jimenez";
            Console.WriteLine($"Outside Main method\n-------------\n{firstEmp} \n{secondEmp}\n");
        }

        static void SayHi(string name)
        {
            Console.WriteLine($"Welcome back, {name}");
        }
    }
}
