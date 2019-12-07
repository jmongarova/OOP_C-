using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("lisenko@gmail.com","Maxim","Lisenko",24,"06.12.2019");
            user.Show();
            user.Login_ = "lisenk1234o@gmail.com";
            user.FirstName_ = "Misha";
            user.LastName_ = "Lisenkoo";
            user.Age_ = 25;
            user.Show();
            Console.ReadKey();
        }
    }
}
