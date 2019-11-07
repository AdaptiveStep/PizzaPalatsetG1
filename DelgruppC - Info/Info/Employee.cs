using System;
using System.Collections.Generic;
using System.Text;

namespace Info
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
