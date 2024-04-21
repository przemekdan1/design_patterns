using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class _2DPolarInheritance : Vector2D
    {
        public _2DPolarInheritance(double x, double y) : base(x, y)
        {
            Console.WriteLine($"Creating 2d vector via inheritance [{x},{y}]");
        }

        public double GetAngle()
        {
            return Math.Atan2(this.GetComponents()[1], this.GetComponents()[0]);
        }
    }
}
