using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal lion = new Mammal();
            // lion.Age = 25;
            Console.WriteLine("This is your first inherited class: ");
            Console.WriteLine(lion.PersonalName);
            Console.WriteLine(lion.Age);

            lion.PersonalName = "Nala";
            lion.Age = 10;
            Console.WriteLine("We have set new values to our Lion class: ");
            Console.WriteLine(lion.PersonalName);
            Console.WriteLine(lion.Age);

        }
    }
    
}
