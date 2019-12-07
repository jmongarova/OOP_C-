using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._2
{
    class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;
        public int Index
        {
            get{return index;}
            set{index = value;}
        }
        public string Country //Они обеспечивают простой доступ к полям классов и структур, узнать их значение или выполнить их установку.
        {
            get { return country; }//В блоке get мы возвращаем значение поля
            set { country = value; }// set устанавливаем значение, value-представляет передаваемое значение
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string House
        {
            get { return house; }
            set { house = value; }
        }
        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
        public void InfoAddress()
        {
            Console.WriteLine($"Индекс: {Index}  \nCountry: {country} \nCity: {city} \nStreet: {street} \nHouse: {house} \nApartment: {apartment}");
        }
    }
}
