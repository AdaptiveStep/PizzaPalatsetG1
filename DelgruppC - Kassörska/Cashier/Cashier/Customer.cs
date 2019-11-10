using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier
{
    public class Customer : Person
    {
        public int _kredit { get; set; }

        public Customer()
        {
            _kredit = 1000;
        }
    }
}
