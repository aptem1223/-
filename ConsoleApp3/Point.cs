using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    // Класс Point хранит координаты и название точки
    class Point
    {
        private int x;
        private int y;
        private string name;

        // Конструктор инициализирует поля
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        // Свойства только для чтения
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public string Name { get { return name; } }
    }
}
