using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Vector3DDecorator: IVector
    {
        private IVector srcVector;
        private double z;
        public Vector3DDecorator(IVector srcVector)
        {
            this.srcVector = srcVector;
            Console.WriteLine($"Creating 3d vector [{srcVector.GetComponents()[0]},{srcVector.GetComponents()[1]},{srcVector.GetComponents()[2]}]");
        }

        public double Abs()
        {
            double[] components = srcVector.GetComponents();
            double x = components[0];
            double y = components[1];
            double z = components[2];

            return Math.Sqrt(Math.Pow(x, 2.0) + Math.Pow(y, 2.0) + Math.Pow(z, 2.0));
        }

        public double Cdot(IVector vector)
        {
            double[] components1 = srcVector.GetComponents();
            double x1 = components1[0];
            double y1 = components1[1];
            double z1 = components1[2];

            double[] components2 = vector.GetComponents();
            double x2 = components2[0];
            double y2 = components2[1];
            double z2 = components2[2];

            return x1*x2+ y1*y2 + z1*z2;
        }

        public double[] GetComponents()
        {
            return srcVector.GetComponents();
        }

        public Vector3DDecorator Cross(IVector vector) 
        {
            double[] components1 = srcVector.GetComponents();
            double x1 = components1[0];
            double y1 = components1[1];
            double z1 = components1[2];

            double[] components2 = vector.GetComponents();
            double x2 = components2[0];
            double y2 = components2[1];
            double z2;

            if (components2.Count() == 3)
                z2 = components2[2];
            else z2 = 0.0;

            double res_x = y1 * z2 - z1 * y2;
            double res_y = z1 * x2 - x1 * z2;
            double res_z = x1 * y2 - y1 * x2;

            Vector3DInheritance res2Dvect = new Vector3DInheritance(res_x,res_y,res_z);

            return new Vector3DDecorator(res2Dvect);
        }

        public IVector GetSrcV()
        {
            return this.srcVector;
        }
    }
}
