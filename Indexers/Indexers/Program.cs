using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal[0] = "Dog";
            animal[1] = "Wolf";
            animal[2] = "Horse";

            Console.WriteLine(animal[2]);
            dynamic value = 0;
            Console.WriteLine("Value is "+value);
            Console.WriteLine("Value type is "+value.GetType().Name);
            Console.WriteLine();

            value = new Animal();
            value.Type = "Dog";
            Console.WriteLine("Value is "+value.Type);
            //Console.WriteLine("Value type is " + value.GetType().Type);
            Console.WriteLine();
        }
    }

    class Animal
    {
        private string[] name = new string[100];

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }


        public string this[int index]
        {
            get { return name[index]; }
            set { name[index] = value; }
        }
    }
}
