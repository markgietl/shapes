using System;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            circle acirc = new circle(766);
            square asquare = new square(5, 7);
            Console.WriteLine("The area of the circle is " + acirc.area());
            Console.WriteLine("The area of the square is " + asquare.area());

        }

    }
}
