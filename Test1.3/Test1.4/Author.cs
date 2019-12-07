using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._4
{
    class Author
    {
        private string author;
        public string Author_
        {
            get { return author; }
            set { author = value; }
        }
        public  void Show() 
        {
           
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine($"Автор-> {author}");
            Console.ResetColor();
        }
    }
}
