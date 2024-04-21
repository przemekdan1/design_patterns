using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Polar2DAdapter : IVector, IPolar2D
    {

        private Vector2D srcVector;

        public Polar2DAdapter(Vector2D srcVector)
        {
            this.srcVector = srcVector;
            Console.WriteLine($"Creating 2d vector via adapter [{srcVector.GetComponents()[0]},{srcVector.GetComponents()[1]}]");
        }

        public double Abs()
        {
            return this.srcVector.Abs();
        }

        public double Cdot(IVector param)
        {
            return this.srcVector.Cdot(param);
        }
        public double[] GetComponents()
        {
            return this.srcVector.GetComponents();
        }

        public double GetAngle() 
        { 
            return Math.Atan2(this.srcVector.GetComponents()[1], this.srcVector.GetComponents()[0]);
        }

    }
}
