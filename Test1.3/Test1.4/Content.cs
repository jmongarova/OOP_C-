using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._4
{
    class Content 
    {
        private string content;
        public string Content_
        {
            get { return content; }
            set { content = value; }
        }
        public  void Show()
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Жанр-> {content}");
            Console.ResetColor();
        }
    }
}
