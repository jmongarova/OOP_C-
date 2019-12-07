using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._7
{
    class Converter
    {
        private double usd;
        private double eur;
        private double rub;
        public Converter(double Usd, double Eur, double Rub) 
        {
            usd = Usd ;
            eur = Eur ;
            rub = Rub;
        }
        public double Usd_
        {
            get { return usd; }
            set { usd = value; }
        }
        public double Eur_
        {
            get { return eur; }
            set { eur = value; }
        }
        public double Rub_
        {
            get { return rub; }
            set { rub = value; }
        }
        public double ConvertUAHtoUSD(double u)
        {
            return u / usd;
        }
        public double ConvertUAHtoEUR(double e)
        {
            return e / eur;
        }
        public double ConvertUAHtoRUB(double r) 
        {
            return r / rub;
        }
        public double ConvertUSDtoUAH(double u)
        {
            return u * usd;
        }
        public double ConvertEURtoUAH(double e)
        {
            return e * eur;
        }
        public double ConvertRUBtoUAH(double r)
        {
            return r * rub;
        }
        public void Show()
        {
            Console.WriteLine($"UAH/USD Перевод составил = {Usd_} UAH/EUR Перевод составил = {Eur_} UAH/RUB Перевод составил = {Rub_}");
        }
    }
}
