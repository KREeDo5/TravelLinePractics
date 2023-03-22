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
                    try
                    {
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
                    catch (FormatException)
                    {
                        Console.WriteLine("format exception");
                    }
                }
                else if (name == "круг")
                {
                    double radius;
                    Console.Write("Введите радиус: ");
                    try
                    {
                        radius = Convert.ToInt32(Console.ReadLine());
                        if (radius >= 0)
                        {
                            Circle circle = new Circle(radius);
                            circle.ShowAreaAndPerimeter();
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: Вы ввели отрицательный радиус.");
                        }
                    } catch (FormatException)
                    {
                        Console.WriteLine("Format Exception");
                    }
                }
                else if (name == "квадрат")
                {
                    double side;
                    Console.Write("Введите сторону квадрата: ");
                    try
                    {
                        side = Convert.ToInt32(Console.ReadLine());
                        Square square = new Square(side);
                        square.ShowAreaAndPerimeter();

                    } catch (FormatException)
                    {
                        Console.WriteLine("Format Exception");
                    }
                }                
            }
            else
            {
                Console.WriteLine($"Фигура '{name}' не предусмотрена программой");
            }
        }
    }
}
