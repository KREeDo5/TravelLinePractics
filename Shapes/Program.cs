using System.Text;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string name;
            string[] shapes = { "треугольник", "круг", "квадрат" };
            Console.Write("Введите название фигуры в нижнем регистре: ");
            name = Console.ReadLine();
            if (shapes.Contains(name))
            {
                if (name == "треугольник")
                {
                    double a, b, c;
                    Console.Write("Введите сторону A: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите сторону B: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите сторону C: ");
                    c = Convert.ToInt32(Console.ReadLine());
                    if ((a < (b + c)) && (b < (a + c)) && (c < (a + b)))
                    {
                        Triangle triangle = new Triangle(a, b, c); ;
                        triangle.ShowAreaAndPerimeter();
                    }
                    else
                    {
                        Console.WriteLine("Такого треугольника не существует. Проверьте значения сторон.");
                    }
                }
                else if (name == "круг")
                {
                    double radius;
                    Console.Write("Введите радиус: ");
                    radius = Convert.ToInt32(Console.ReadLine());
                    Circle circle = new Circle(radius);
                    circle.ShowAreaAndPerimeter();
                }
                else if (name == "квадрат")
                {
                    double side;
                    Console.Write("Введите сторону квадрата: ");
                    side = Convert.ToInt32(Console.ReadLine());
                    Square square = new Square(side);
                    square.ShowAreaAndPerimeter();
                }
            }
            else
            {
                Console.WriteLine($"Фигура '{name}' не предусмотрена программой");
            }
        }
    }
}
