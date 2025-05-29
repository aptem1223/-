using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    // Класс Figure — многоугольник из 3-5 точек
    class Figure
    {
        private Point[] points;

        // Конструктор для 3 точек (треугольник)
        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[] { p1, p2, p3 };
        }

        // Конструктор для 4 точек (четырёхугольник)
        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[] { p1, p2, p3, p4 };
        }

        // Конструктор для 5 точек (пятиугольник)
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[] { p1, p2, p3, p4, p5 };
        }

        // Метод для вычисления длины стороны между двумя точками
        public double LengthSide(Point A, Point B)
        {
            int dx = A.X - B.X;
            int dy = A.Y - B.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Метод для вычисления периметра многоугольника
        public double PerimeterCalculator()
        {
            double perimeter = 0;
            int count = points.Length;

            for (int i = 0; i < count; i++)
            {
                // Соединяем текущую точку с следующей (или с первой, если последняя)
                Point current = points[i];
                Point next = points[(i + 1) % count];
                perimeter += LengthSide(current, next);
            }

            return perimeter;
        }

        // Метод для получения названия фигуры (например, "Треугольник", "Четырёхугольник", "Пятиугольник")
        public string GetFigureName()
        {
            switch (points.Length)
            {
                case 3:
                    return "Треугольник";
                case 4:
                    return "Четырёхугольник";
                case 5:
                    return "Пятиугольник";
                default:
                    return "Многоугольник";
            }
        }
    }
}
