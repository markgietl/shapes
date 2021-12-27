using System;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle acirc = new Circle(766);
            Square asquare = new Square(5, 7);
            Console.WriteLine("The area of the circle is " + acirc.Area());
            Console.WriteLine("The area of the square is " + asquare.Area());

        }

    }
}
