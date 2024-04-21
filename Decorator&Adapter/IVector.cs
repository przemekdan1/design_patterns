using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    interface IVector
    {
        public double[] GetComponents();
        public double Abs();
        public double Cdot(IVector v);
    }
}
