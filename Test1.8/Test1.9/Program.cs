using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice i = new Invoice(40,"АТБ","Lactel");
            i.Quantity=160;
            i.Article = "Дольче_йогурт";
            i.Calculate();
            Console.ReadKey();
        }
    }
}
