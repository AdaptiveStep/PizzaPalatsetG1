using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier
{
    public class Employee : Person
    {
        public string _password { get; set; }
        public Employee()
        {
            _password = "Password123";
        }
    }
}
