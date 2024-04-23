using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeVirt
{
    internal class Rectangle : Shape
    {
        private double _length;
        private double _width;
        public double Length
        {
            get { return _length; }
            set
            {
                if(value > 0)
                {
                     _length = value;
                }
            }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
            }
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
            
        }
        public override double Area()
        {
            return S = Length*Width;
        }
        public override double Perimetr()
        {
            return P= 2*(Length+Width);
        }



    }
}
