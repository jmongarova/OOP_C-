using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._9
{
    class Invoice
    {
        private int account;
        private string customer;
        private string provider;
        private string article;
        private int quantity = 1;
        public Invoice(int a, string c, string p)
        {
            account = a;
            customer = c;
            provider = p;
        }
        public int Account
        {
            get { return account; }
        }
        public string Customer
        {
            get { return customer; }
        }
        public string Provider
        {
            get { return provider; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public string Article
        {
            get { return article; }
            set { article = value; }
        }
        public void Calculate() 
        {
            int BN = 160 * 40;
            int NDS = BN / 6;
            int N = BN - NDS;
            Console.WriteLine($"Стоимость заказа с НДС ->{BN} и стоимость заказа без учета НДС->{N}");
        }
    }
}
