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
    /*Abstract Super klass. Skapar en ny person med namn och ett ID.
     Person klassen i version @1.0 har funktionaliteten för att använda namn,
     men det kan implementeras i senare versioner om nödvändigt*/
    public abstract class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }
        private static int IDCounter = 1;
        private List<string> names = new List<string> { "Johan", "Camilla", "Sofie", "Gunnar", "Björn", "Amanda" };

        public Person()/*I konstruktorn slumpas ett nytt namn fram, och ID ökar för varje ny instansiering av personklassen.*/
        {
            long seed = (DateTime.Now.Ticks);
            Random random = new Random((int)seed);

            int myNamePosition = random.Next(0, 5);
            this.Name = names[myNamePosition];
            ID = IDCounter;
            IDCounter++;
        }
    }
}
