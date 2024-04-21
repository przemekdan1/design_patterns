using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Vector3DInheritance : Vector2D, IVector
    {

        private double z;
        public Vector3DInheritance(double x, double y, double z) : base(x,y)
        {
            this.z = z;
            Console.WriteLine($"Creating 3d vector [{x},{y},{z}]");
        }

        public double Abs()
        {
            return Math.Sqrt(Math.Pow(base.GetComponents()[0], 2.0) + Math.Pow(base.GetComponents()[1], 2.0) + Math.Pow(this.z, 2.0));
        }

        public double[] GetComponents()
        {
            double[] components = base.GetComponents();

            double x = components[0];
            double y = components[1];
            double z = this.z;
            return new double[] {x,y,z};
        }

        public double Cdot(IVector vector)
        {
            double[] components = base.GetComponents();

            double x = components[0];
            double y = components[1];
            double z = this.z;
            return x * vector.GetComponents()[0] + y * vector.GetComponents()[1] + z * vector.GetComponents()[2];
        }

        public Vector3DInheritance Cross(IVector vector) 
        {
            double[] components1 = base.GetComponents();

            double x1 = components1[0];
            double y1 = components1[1];
            double z1 = this.z;

            double[] components2 = vector.GetComponents();

            double x2 = components2[0];
            double y2 = components2[1];
            double z2 = components2[2];

            return new Vector3DInheritance(y1 * z2 - z1 * y2, z1 * x2 - x1 * z2, x1 * y2 - y1 * x2);
        }

        public IVector GetSrcV(double x, double y, double z)
        {
            return new Vector3DInheritance(x,y,z);
        }


    }
}
