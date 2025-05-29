using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем точки с именами и координатами
            Point p1 = new Point(0, 0, "A");
            Point p2 = new Point(4, 0, "B");
            Point p3 = new Point(4, 3, "C");

            // Создаем фигуру — треугольник из трех точек
            Figure triangle = new Figure(p1, p2, p3);

            // Выводим название фигуры и её периметр
            Console.WriteLine($"Название фигуры: {triangle.GetFigureName()}");
            Console.WriteLine($"Периметр: {triangle.PerimeterCalculator():F2}");

            Console.ReadKey();
        }
    }
}
