using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Title
    {
        private string title;

        // Конструктор для инициализации названия
        public Title(string title)
        {
            this.title = title;
        }

        // Метод вывода названия книги цветом
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;  // Цвет для названия (голубой)
            Console.WriteLine($"Название книги: {title}");
            Console.ResetColor();
        }
    }

    // Класс Author хранит имя автора и умеет его показывать
    class Author
    {
        private string authorName;

        // Конструктор для инициализации имени автора
        public Author(string authorName)
        {
            this.authorName = authorName;
        }

        // Метод вывода имени автора цветом
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;  // Цвет для автора (зеленый)
            Console.WriteLine($"Автор: {authorName}");
            Console.ResetColor();
        }
    }
}
