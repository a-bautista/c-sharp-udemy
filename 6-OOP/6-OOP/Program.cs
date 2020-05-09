using System;

namespace _6_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Kia car = new Kia();
            car.DisplayInfo();
        }
    }

    #region Car - This is the solution of the exercise
    abstract class Car
    {
        private decimal price;
        private string year;
        public  string color;
        protected int maxSpeed;
        public abstract void DisplayInfo();
        protected decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        protected string Year
        {
            get { return year; }
            set { year = value; }
        }
    }
    #endregion

    class Kia : Car
    {
       
        public override void DisplayInfo()
        {
            base.maxSpeed = 300;
            base.color = "black";
            base.Price = 10000;
            base.Year = "2012";
            Console.WriteLine($"The {Year} car of color {color} is worth {Price} with a max speed of {maxSpeed}");
        }
    }
}
