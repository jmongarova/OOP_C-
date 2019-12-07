using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._4
{
    class Title
    {
        private string title;
        public string Title_
        {
            get { return title; }
            set { title = value; }
        }
        
        public  void Show()
        {
           
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
            Console.WriteLine($"Титулка-> {title}");
            Console.ResetColor(); // сбрасываем в стандартный
        }
    }
}
    
