using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    public class Triangle: Shape
    {
        private double _Base {  get; set; }
        private double _Height { get; set; }

        public Triangle (double @base, double height) 
        {
         
            _Base = @base;
            _Height = height;
        }
        public override double CalculateArea()
        {
            return _Base*_Height;
        }
    }

}
