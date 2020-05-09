using System;

namespace _15_AdvancedCollections_GenericClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Building<int> empireState = new Building<int>();
            empireState.Name = "Empire State";
            empireState.City = "New York";
            empireState.Height = 443;
            empireState.Weight = 365000;

            Building<double> burjKhalifa = new Building<double>();
            burjKhalifa.Name = "Burj Khalifa";
            burjKhalifa.City = "Dubai";
            burjKhalifa.Height = 830;
            burjKhalifa.Weight = 450000;

            Console.WriteLine("Name: "+ empireState.Name);
            Console.WriteLine("City: " + empireState.City);
            Console.WriteLine("Height: " + empireState.Height);
            Console.WriteLine("Weight: " + empireState.Weight);


            Console.WriteLine("Name: " + burjKhalifa.Name);
            Console.WriteLine("City: " + burjKhalifa.City);
            Console.WriteLine("Height: " + burjKhalifa.Height);
            Console.WriteLine("Weight: " + burjKhalifa.Weight);

        }
    }

    class Building<T>
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private T height;
        public T Height
        {
            get { return height; }
            set { height = value; }
        }

        private T weight;
        public T Weight
        {
            get { return weight; }
            set { weight = value; }
        }

    }
}
