using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs dog = new Dogs();
            dog.Lay();
            dog.SayHi();
        }
    }

    public interface IAnimal
    {
        void Run();
    }

    public interface IDogCommands // interfaces are public by default
    {
        void Stay();
        void Sit();
        void Lay();

        string DogName
        {
            set;
            get;
        }
    }

    class Animal
    {
        string AnimalName;
        public void SayHi()
        {
            Console.WriteLine("Hi from the animals class!");
        }
    }

    class Dogs: Animal, IDogCommands, IAnimal // the class comes first before any other interface
    {
        private string DogBreed;
        public void Stay()
        {
            Console.WriteLine("The dog is waiting.");
        }

        public void Sit()
        {
            Console.WriteLine("The dog is seated.");
        }

        public void Lay()
        {
            Console.WriteLine("The dog is laying.");
        }

        public void Run()
        {
            Console.WriteLine("The animal is running.");
        }

        public string DogName
        {
            get;
            set;
        }
    }
}
