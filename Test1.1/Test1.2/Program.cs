using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Address Ivanov= new Address();//создание экземпляра класса, объекта
            Ivanov.Index = 14568;
            Ivanov.Country = "USA";
            Ivanov.City = "Boston";
            Ivanov.Street = "Massachusetts Avenue ";
            Ivanov.House = "126";
            Ivanov.Apartment = "1";
            Ivanov.InfoAddress();//вызов метода вывода на консоль
            Console.ReadKey();//задержка экрана
        }
    }
}
