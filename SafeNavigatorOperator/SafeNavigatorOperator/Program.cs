using System;
using System.Collections.Generic;

namespace SafeNavigatorOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw3 = new Car();
            Car porscheCarreraGT = new Car();

            bmw3.Brand = "BMW";
            bmw3.Model = "M5";
            bmw3.Price = 60_000;

            porscheCarreraGT.Brand = "Porsche";
            porscheCarreraGT.Model = "Carrera GT";
            porscheCarreraGT.Price = 500_000;

            Console.WriteLine("Car Information");
            Car.DisplayCarDetails(bmw3);
            Car.DisplayCarDetails(porscheCarreraGT);

            List<Car> listOfCars = new List<Car>();
            //List <Car> listOfCars = null;
            int? count = 0;

            count = listOfCars?.Count;
            Console.WriteLine(count);

            listOfCars.Add(bmw3);
            listOfCars.Add(porscheCarreraGT);

            foreach (var car in listOfCars)
            {
                Console.WriteLine(car);
            }
        }
    }

    class Car
    {
        private string brand;
        private string model;
        private double price;
        
        public string Brand
        {
            get => brand; 
            set => brand = value; 
        }

        public string Model
        {
            get => model; 
            set => model = value; 
        }

        public double Price
        {
            get => price; 
            set => price = value; 
        }

        public static void DisplayCarDetails(Car car)
        {
            // These conditionals will be replaced by the safe type operators
            // if (car.Brand!=null)
            //    Console.WriteLine(car.Brand);
            // if (car.Model != null)
            //    Console.WriteLine(car.Model);
            // if (car.Price != null)
            //    Console.WriteLine(car.Price);

            Console.WriteLine(car?.Brand);
            Console.WriteLine(car?.Model);
            Console.WriteLine(car?.Price);


            Console.WriteLine("------------");
        }

    }
}
