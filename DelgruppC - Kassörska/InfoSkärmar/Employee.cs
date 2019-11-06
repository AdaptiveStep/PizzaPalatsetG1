using System;
using System.Collections.Generic;
using System.Text;

namespace InfoSkärmar
{
    class Employee : Person
    {
        public string _password { get; set; }

        public Employee()
        {
            _password = "Password123";
        }
    }
}
