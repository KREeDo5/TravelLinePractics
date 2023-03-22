using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle : IShape
    {
        private double _a;
        private double _b;
        private double _c;
        private double _p;
        
        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
            _p = (a + b + c) / 2;
        }
        public double CalculateArea()
        {
            var area = Math.Sqrt(_p * (_p - _a) * (_p - _b) * (_p - _c));
            return area;
        }
        public double CalculatePerimeter()
        {
            var perimeter = _a + _b + _c;
            return perimeter;
        }
        public void ShowAreaAndPerimeter()
        {
            var perimeter = CalculatePerimeter();
            Console.WriteLine($"Периметр равен:{perimeter}");
            var area = CalculateArea();
            Console.WriteLine($"Площадь равна:{area}");
        }
    }
}
