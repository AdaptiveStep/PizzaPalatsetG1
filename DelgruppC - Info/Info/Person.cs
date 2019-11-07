using System;
using System.Collections.Generic;
using System.Text;

namespace Info
{
    class Person
    {
        public string _name { get; set; }
        public int _ID { get; set; }

        private List<string> names = new List<string> { "Johan", "Camilla", "Sofie", "Gunnar", "Björn", "Amanda" };
        public Person()
        {
            long seed = (DateTime.Now.Ticks);
            Random random = new Random((int)seed);

            int myNamePosition = random.Next(0, 5);
            this._name = names[myNamePosition];

            _ID = random.Next(00, 99);
        }
    }
}
