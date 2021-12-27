using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : Shape 
    {
        public float length;
        public float breadth;
        public Square()
        {

        }
        public Square(float length, float breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override void GetCorners()
        {
            Console.WriteLine("I have 4 sides.");
        }
        public override void Print()
        {
            Console.WriteLine("I am a square, hehe!");
        }
        public override float Area()
        {
            return (this.length * this.breadth);
        } 
    }
}
