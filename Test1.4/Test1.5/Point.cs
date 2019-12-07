using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._5
{
    class Point
    {
        private int a;
        private int b;
        private string s;
        public int X_
        {
            get { return a; }
        }
        public int Y_
        {
            get { return b; }
        }
        public string Name_
        {
            get { return s; }
        }
        public Point(int x, int y, string name)
        {
            a = x;
            b = y;
            s = name;
        }
    }
}
