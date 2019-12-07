using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A=new Point(3,1,"A");
            Point B = new Point(6, 1,"B");
            Point C = new Point(9, 4, "C");
            Figure f = new Figure(A, B, C);
            
            double p = f.PerimetrCalculator();
            Console.WriteLine($" многоугольник {f.str}  периметр {p}");
            Console.ReadKey();
        }
    }
}
