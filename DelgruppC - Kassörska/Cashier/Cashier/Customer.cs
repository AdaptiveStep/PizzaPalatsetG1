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
    /*Subklass till Person. Skapar en kund och tilldelar kunden ett kredit/banksaldo.*/
    public class Customer : Person
    {
        public int _kredit { get; set; }
        public Customer()
        {
            _kredit = 1000;
        }
    }
}
