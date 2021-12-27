using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class square : Shape 
    {
        public float length;
        public float breadth;
        public square()
        {

        }
        public square(float length, float breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override void getCorners()
        {
            Console.WriteLine("I have 4 sides.");
        }
        public override void print()
        {
            Console.WriteLine("I am a square, hehe!");
        }
        public override float area()
        {
            return (this.length * this.breadth);
        } 
    }
}
