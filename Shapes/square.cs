using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : Shape 
    {
        public static int number = 0;
        private float length;
        private float breadth;
        public Square()
        {

        }
        public Square(float length, float breadth)
        {
            number++;
            this.length = length;
            this.breadth = breadth;
            Console.WriteLine($"I am square number {number}");
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
