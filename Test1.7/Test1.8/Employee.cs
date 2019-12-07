using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._8
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private string dolgnost;
        private double oklad;
        private double stag;
        private double NDS;
        public Employee(string FirstName,string LastName) 
        {
            firstName = FirstName;
            lastName = LastName;
        }
        public string FirstName_
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName_
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Dolgnost_
        {
            get { return dolgnost; }
            set { dolgnost = value; }
        }
        public double Oklad_
        {
            get { return oklad; }
            set { oklad = value; }
        }
        public double Stag_
        {
            get { return stag; }
            set { stag = value; }
        }
        public double NDS_
        {
            get { return NDS; }
        }
        public double OkladCalculate()
        {
            double nadb=0;
            double z = 0;
            if (Stag_ < 3){ Stag_ = 1; }
            else if(Stag_>=3) { Stag_ = 0.10; nadb = (Oklad_ - NDS_) * Stag_; }
            else if (Stag_ >= 10) { Stag_ = 0.20; nadb = (Oklad_ - NDS_) * Stag_; }
            z= nadb + Oklad_;
            NDS = z * 0.22;
            z = z - NDS;
            return z;
        }
        public void Show()
        {
            double res = OkladCalculate();
            Console.WriteLine($"Имя: {FirstName_}  \nФамилия: {LastName_} \nДолжность: {Dolgnost_} \nОклад: {Oklad_} \nКоэфициент стажа: {Stag_} \nНалоговый сбор: {NDS_} \nОклад с высчитами {res}");
        }
    }
}
