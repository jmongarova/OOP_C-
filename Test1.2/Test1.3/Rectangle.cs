using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._3
{
    class Rectangle
    {
        public double side1, side2;
        public Rectangle(double sideone, double sidetoo) { side1 = sideone; side2 = sidetoo; }
        public double AreaCalculator()
        {
  
            return side1 * side2; 
        }
        public double PerimeterCalculator()
        {

            return 2 * (side1 + side2);
        }
        public double Area { get { return AreaCalculator();} }
        public double Perimeter { get { return PerimeterCalculator(); } }
        public void Show()
        {
            Console.WriteLine($"Площадь прямоугольника-> {Area} и периметр прямоугольника-> {Perimeter}");
        }
    }
    
}
