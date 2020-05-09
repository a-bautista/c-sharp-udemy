using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables: what's the difference between a float, double and decimal
            Console.WriteLine("Enter your number down below");
            int input_number = 0;
            // Handle an error exception
            int.TryParse(Console.ReadLine(),out input_number);

            if (input_number == 0)
            {
                Console.WriteLine("This is not a valid input. ");
            }
            else
            {
                Console.WriteLine("You have entered your number: " + input_number);
            }
            
            int    x            = 9;
            double double_num   = 5.0d;
            float  float_num    = 10.0f;
            decimal decimal_num = 0.0m;
            const double gravityForce = 9.8; // declare constant value
            double PI = 3.141592;

            string y = "9";
            string  firstName = "Alejandro";
            string lastName   = "Bautista";
            bool IsWorking    = true;

            double  a = 1 / 3d;
            decimal b = 1 / 3m;
            if (a.ToString() == b.ToString())
            {
                Console.WriteLine("x equal y");
            }


            var test = 1000; // the var keyword can be used to define any type of variable

            // conversion of values
            double_num  = 9.8;
            decimal_num = 100.25m;
            
            // convert is going to round the number
            x = Convert.ToInt32(double_num);

            Double num = 2.5d;
            Double num2 = 2.5;
            //Decimal num4 = 2.5;
            Decimal num3 = 2.5m;


            // Output 
            Console.WriteLine("Double num is: "  + double_num);
            Console.WriteLine("Float num is: "   + float_num);
            Console.WriteLine("Decimal num is: " + decimal_num);
            Console.WriteLine("This is the first name: " + firstName);
            Console.WriteLine("This is the last name: " + lastName);
            Console.WriteLine(7 + 16);
            Console.WriteLine(x);
            Console.Write("This is the last name: " + firstName + " " + lastName);





        }
    }
}
