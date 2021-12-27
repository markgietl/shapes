using System;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            circle acirc = new circle();
            square asquare = new square();
            Console.WriteLine("The area of the circle is " + acirc.area(7));
            Console.WriteLine("The area of the square is " + asquare.area(4, 5));

        }

    }
}
