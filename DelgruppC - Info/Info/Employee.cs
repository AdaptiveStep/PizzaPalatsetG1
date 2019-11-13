using System;
using System.Collections.Generic;
using System.Text;
/*  Autor: @ Grupp 1
 *  Version @1.0
 *  marcuswelin88@gmail.com
 */
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
