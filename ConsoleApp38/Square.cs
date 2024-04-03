using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    public class Square : Shape
    {
        private double _side;
        public double Side
        {
            get
            {
                return _side;
            }
            set
            {
                _side = value;
            }
        }
        public Square(double side)
        {
            Side = side;
        }
        public override double CalculateArea()
        {
            return Side * _side;
        }
    }
}
