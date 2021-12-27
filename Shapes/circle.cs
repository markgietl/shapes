using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class circle : Shape
    {
        public circle()
        {

        }
        public override void getCorners()
        {
            Console.WriteLine("I have no sides mate!");
        }
        public void print()
        {
            Console.WriteLine("I'm a circle bro!");
        }
        public float area(float rad)
        {
            return (float)Math.PI * rad * rad;

        }
    }
}
