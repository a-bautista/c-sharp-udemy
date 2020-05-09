using System;

namespace _4_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            //shapes[0] = new Shape(); // cannot instantiate it because it is an abstract class
            shapes[0] = new Circle();
            shapes[1] = new Triangle();
            shapes[2] = new Square();


            foreach (var shape in shapes)
            {
                shape.Draw();
                shape.AbstractMethodDraw();
            }
        }
    }

    abstract class Shape
    {
        abstract public void AbstractMethodDraw(); //abstract methods should always be instantianted in the child classes
        public virtual void Draw()
        {
            Console.WriteLine("I am a shape.");
        }
    }

    class Square: Shape
    {
        public override void AbstractMethodDraw()
        {
            Console.WriteLine("Square: Abstract method");
        }

        public override void Draw() // you can use override or new but if you use new then you will use the method from the parent class
        {
            Console.WriteLine("I am a square.");
        }
    }

    class Triangle : Shape
    {

        public override void AbstractMethodDraw()
        {
            Console.WriteLine("Triangle: Abstract method");
        }

        public override void Draw() // the words virtual and overrride are necessary when you try to change the methods of an object with Polymorphism
        {
            Console.WriteLine("I am a triangle.");
        }
    }

    class Circle : Shape
    {

        public override void AbstractMethodDraw()
        {
            Console.WriteLine("Circle: Abstract method");
        }

        public override void Draw() // the words virtual and overrride are necessary when you try to change the methods of an object with Polymorphism
        {
            Console.WriteLine("I am a circle.");
        }
    }
}
