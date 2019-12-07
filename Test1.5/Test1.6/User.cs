using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._6
{
    class User
    {
        private string login;
        private string firstName;
        private string lastName;
        private int age;
        private string data;
        public User(string Login, string FirstName, string LastName, int Age, string Data)
        {
            login = Login;
            firstName = FirstName;
            lastName = LastName;
            age = Age;
            data = Data;
        }
        public string Login_
        {
            get { return login; }
            set { login = value; }
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
        public int Age_
        {
            get { return age; }
            set { age = value; }

        }
        public string Data_
        {
            get { return data; }

        }
        public void Show()
        {
            Console.WriteLine($"login: {Login_} Name {FirstName_} Last Name {LastName_} Age {Age_} Data {Data_}");    
        }
    }
}
