using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeVirt
{
    internal class Shape
    {
        public double P { get; set; }
        public double S { get; set; }
        public virtual double Perimetr()
        {
            return P;
        }
        public virtual double Area()
        {
            return S;
        }
    }
}
