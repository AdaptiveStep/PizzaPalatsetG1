using System;
using System.Collections.Generic;
using System.Text;
/*  Autor: @ Grupp 1
 *  Version @1.0
 *  marcuswelin88@gmail.com
 */
namespace Info
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
