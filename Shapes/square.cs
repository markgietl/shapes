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
        private float Length { get; set;}
        private float Breadth { get; set;} 
        public Square()
        {

        }
        public Square(float length, float breadth)
        {
            number++;
            this.Length = length;
            this.Breadth = breadth;
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
            return (this.Length * this.Breadth);
        } 
    }
}
