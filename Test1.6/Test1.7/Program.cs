using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int val;
            Converter v = new Converter(23.85, 26.25, 0.365);
            Console.Write("Введите вашу сумму: ");
            double value = Convert.ToDouble(Console.ReadLine());
            Console.Write("Перевод:\n1) UAH/USD \n2) UAH/EUR \n3) UAH/RUB \n4) USD/UAH \n5) EUR/UAH \n6) RUB/UAH\n\nВаш выбор: ");
            do
            {
                val = Convert.ToInt32(Console.ReadLine());
                switch (val)
                {
                    case 1: Console.WriteLine($"UAH/USD Перевод составил = {v.ConvertUAHtoUSD(value):f2} USD"); break;
                    case 2: Console.WriteLine($"UAH/EUR Перевод составил = {v.ConvertUAHtoEUR(value):f2} EUR"); break;
                    case 3: Console.WriteLine($"UAH/RUB Перевод составил = {v.ConvertUAHtoRUB(value):f2} RUB"); break;
                    case 4: Console.WriteLine($"USD/UAH Перевод составил = {v.ConvertUSDtoUAH(value):f2} UAH"); break;
                    case 5: Console.WriteLine($"EUR/UAH Перевод составил = {v.ConvertEURtoUAH(value):f2} UAH"); break;
                    case 6: Console.WriteLine($"RUB/UAH Перевод составил = {v.ConvertRUBtoUAH(value):f2} UAH"); break;
                    default: Console.WriteLine("Такой валюты у нас нет..."); break;
                }
            } while (val < 7);
        }
    }
}
