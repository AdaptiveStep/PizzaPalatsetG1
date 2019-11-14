using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Autor: @ Grupp 1
 *  Version @1.0
 *  jonathan.harlin@icloud.com
 */
namespace Cashier
{
    /*Subklass till Person.
     Hämtar Persons attributer samt tilldelar de anställda ett lösenord*/
    public class Employee : Person
    {
        public string _password { get; set; }
        public Employee()
        {
            _password = "Password123";
        }
    }
}
