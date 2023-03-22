using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : IShape
    {
        private double _radius;
        private double _pi = Math.PI;

        public Circle(double radius)
        {
            _radius = radius;
        }
        public double CalculateArea()
        {
            var area = _pi * Math.Pow(_radius, 2);
            return area;
        }
        public double CalculatePerimeter()
        {
            var perimeter = 2 * _pi * _radius;
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
