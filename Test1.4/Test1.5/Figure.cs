using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._5
{
    class Figure
    {
        Point[] points = new Point[5];
        
        public string str;
        public Figure(Point a, Point b, Point c, Point d = null, Point e = null) 
        {

            points[0]= a;
            points[1] = b;
            points[2] = c;
            if (d != null) { points[3] = d; }
            if (e != null) { points[4] = e; }
        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X_ - b.X_, 2) + Math.Pow(a.Y_ - b.Y_, 2));
        }
        public double PerimetrCalculator()
        {
            double perimeter = 0;

            int n = 5;
            double w;
            bool g=true;
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i] == null) { n--; }
            }
            w= this.LengthSide(points[0], points[n - 1]);
            for (int i = 1; i < n; i++)
            {

                perimeter += this.LengthSide(points[i - 1], points[i]);
                if (this.LengthSide(points[i - 1], points[i]) != w)
                {
                    g=false;
                }
            }
            perimeter += this.LengthSide(points[0], points[n-1]);
            if (!g)
            {
                Console.Write("Неправельный ");
            }
            else
            {
                Console.Write("Правельный");
            }
            return perimeter;
        }

    }
}
