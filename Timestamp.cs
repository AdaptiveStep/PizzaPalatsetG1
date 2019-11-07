using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPalatsetG1
{
    class Timestamp
    {
        public DateTime ordered; // Beställd av kunden
        public DateTime started; // Påbörjad påbörjad av employee
        public DateTime proccessed; // Ordern färdigställd och markerad av employee
        public DateTime finished; // Uthämtad av kunden
    }
}
