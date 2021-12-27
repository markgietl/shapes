using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class circle : Shape
    {
        public float radius;
        public circle()
        {

        }
        public circle(float rad)
        {
            this.radius = rad;
        }
        public override void getCorners()
        {
            Console.WriteLine("I have no sides mate!");
        }
        public override void print()
        {
            Console.WriteLine("I'm a circle bro!");
        }
        public override float area()
        {
            return (float) Math.PI * this.radius * this.radius;

        }
    }
}
