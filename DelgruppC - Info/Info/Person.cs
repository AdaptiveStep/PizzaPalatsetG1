﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Info
{
    public class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }

        private List<string> names = new List<string> { "Johan", "Camilla", "Sofie", "Gunnar", "Björn", "Amanda" };
        public Person()
        {
            long seed = (DateTime.Now.Ticks);
            Random random = new Random((int)seed);

            int myNamePosition = random.Next(0, 5);
            this.Name = names[myNamePosition];

            ID = random.Next(00, 99);
        }
    }
}
