using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Title t = new Title();
            Author a = new Author();
            Content c = new Content();
            Console.WriteLine("Введите название книги");
            string name = Console.ReadLine();
            Console.WriteLine("Введите автора");
            string act = Console.ReadLine();
            Console.WriteLine("Введите жанр");
            string genre= Console.ReadLine();
            t.Title_=name;
            a.Author_ = act;
            c.Content_ = genre;
            //Book b = new Book(t, a, c);
            //Book b = new Book();
            //b.Show();
            Book b = new Book();
            b.Show();
            t.Show();
            a.Show();
            c.Show();
            Console.ReadKey();
        }
    }
}
