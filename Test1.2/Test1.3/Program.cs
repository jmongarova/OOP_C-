using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Введите длину первой стороны и второй через Enter\n");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(a,b);
            rectangle.AreaCalculator();
            rectangle.PerimeterCalculator();
            rectangle.Show();
            Console.ReadKey();
        }
    }
}
