using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class square : Shape 
    {
        public square()
        {

        }
        public override void getCorners()
        {
            Console.WriteLine("I have 4 sides.");
        }
        public void print()
        {
            Console.WriteLine("I'm a square bro!");
        }
        public float area(float l, float b)
        {
            return (l * b);
        } 
    }
}
