using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeVirt
{
    internal class Triangel : Shape
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;
        
        public double FirstSide
        {
            get { return _firstSide; }
            set
            {
                if (value > 0)
                {
                    _firstSide = value;
                }
            }
        }
        public double SecondSide
        {
            get { return _secondSide; }
            set
            {
                if (value > 0)
                {
                    _secondSide = value;
                }
            }
        }
        public double ThirdSide
        {
            get { return _thirdSide; }
            set
            {
                if (value > 0)
                {
                    _thirdSide = value;
                }
            }
        }
        public Triangel(double First,double Second,double Third)
        {
            FirstSide = First;
            SecondSide = Second;
            ThirdSide = Third;
        }
        public override double Perimetr()
        {
            return P = FirstSide + SecondSide + ThirdSide;
        }
        public override double Area()
        {
            Perimetr();
            return S = Math.Sqrt(P/2 * (P / 2 - FirstSide) * (P / 2 - SecondSide) * (P / 2 - ThirdSide));
        }



    }
}
