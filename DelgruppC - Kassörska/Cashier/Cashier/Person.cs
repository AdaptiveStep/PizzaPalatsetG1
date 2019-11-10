using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier
{
    public class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }
        private static int IDCounter = 1;
        private List<string> names = new List<string> { "Johan", "Camilla", "Sofie", "Gunnar", "Björn", "Amanda" };

        public Person()
        {
            long seed = (DateTime.Now.Ticks);
            Random random = new Random((int)seed);

            int myNamePosition = random.Next(0, 5);
            this.Name = names[myNamePosition];
            ID = IDCounter;
            IDCounter++;
            //ID = random.Next(00, 99);
        }
    }
}
