using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя длины сторон прямоугольника
            Console.Write("Введите длину первой стороны: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите длину второй стороны: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            // Создаем объект класса Rectangle с введёнными значениями
            Rectangle rect = new Rectangle(side1, side2);

            // Выводим площадь и периметр с помощью свойств
            Console.WriteLine($"Площадь прямоугольника: {rect.Area}");
            Console.WriteLine($"Периметр прямоугольника: {rect.Perimeter}");

            // Ждем нажатия клавиши, чтобы окно не закрывалось сразу
            Console.ReadKey();
        }
    }
}
