using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Иван","Петров");
            emp.Dolgnost_ = "Meneger";
            emp.Oklad_ = 12000;
            emp.Stag_ = 0;
            Employee emp1 = new Employee("Юрий", "Польский");
            emp1.Dolgnost_ = "Jenitor";
            emp1.Oklad_ = 6000;
            emp1.Stag_ = 10;
            //emp.OkladCalculate();
            //emp1.OkladCalculate();
            emp.Show();
            emp1.Show();
            Console.ReadKey();
        }
    }
}
