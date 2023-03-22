using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : IShape//реализуем интерфейс
    {
        private double _side;

        public Square(double side) 
        {
            _side = side;
        }
        public double CalculateArea()
        {
            var area = Math.Pow(_side, 2);
            return area;
        }
        public double CalculatePerimeter() 
        {
            var perimeter = _side * 4;
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
