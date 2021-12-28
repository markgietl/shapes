using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : Shape
    {
        private float radius;
        private float Radius
        {
            get { return radius;} 
            set { radius = value;} 
        }
        public Circle()
        {

        }
        public Circle(float rad)
        {
            this.radius = rad;
        }
        public override void GetCorners()
        {
            Console.WriteLine("I have no sides mate!");
        }
        public override void Print()
        {
            Console.WriteLine("I'm a circle bro!");
        }
        public override float Area()
        {
            return (float) Math.PI * this.Radius * this.Radius;

        }
    }
}
