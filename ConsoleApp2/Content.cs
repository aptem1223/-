using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Класс Content хранит содержание книги и умеет его показывать
    class Content
    {
        private string contentText;

        // Конструктор для инициализации содержания
        public Content(string contentText)
        {
            this.contentText = contentText;
        }

        // Метод вывода содержания книги цветом
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;  // Цвет для содержания (желтый)
            Console.WriteLine($"Содержание: {contentText}");
            Console.ResetColor();
        }
    }

    // Класс Book объединяет Title, Author и Content
    class Book
    {
        private Title title;
        private Author author;
        private Content content;

        // Конструктор, принимает объекты Title, Author и Content
        public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }

        // Метод вывода всей информации о книге
        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
