using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Vector2D : IVector
    {
        private double x;
        private double y;

        public Vector2D(double x, double y) 
        {
            this.x = x;
            this.y = y;
            Console.WriteLine($"Creating 2d vector [{x},{y}]");
        }


        public double[] GetComponents()
        {
            return new double[] { x, y };
        }

        public double Abs()
        {
            return Math.Sqrt(Math.Pow(x, 2.0) + Math.Pow(y, 2.0));
        }

        public double Cdot(IVector vector)
        {
            double[] components = vector.GetComponents();

            double v1 = components[0];
            double v2 = components[1];
            return this.x * v1 + this.y *v2;
        }
    }
}
