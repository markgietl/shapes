using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal abstract class Shape 
    {
        public abstract void GetCorners();
        public abstract void Print();
        public abstract float Area();
    }
}
