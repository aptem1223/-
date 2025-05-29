using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя данные для книги
            Console.Write("Введите название книги: ");
            string bookTitle = Console.ReadLine();

            Console.Write("Введите имя автора: ");
            string authorName = Console.ReadLine();

            Console.Write("Введите содержание книги: ");
            string bookContent = Console.ReadLine();

            // Создаем объекты для Title, Author и Content
            Title title = new Title(bookTitle);
            Author author = new Author(authorName);
            Content content = new Content(bookContent);

            // Создаем объект Book с этими данными
            Book book = new Book(title, author, content);

            Console.WriteLine("\nИнформация о книге:\n");

            // Выводим всю информацию цветными строками
            book.Show();

            // Ожидаем нажатия клавиши, чтобы окно не закрылось сразу
            Console.ReadKey();
        }
    }
}
