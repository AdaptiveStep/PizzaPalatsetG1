using System;
using System.Collections.Generic;
using System.Text;
/*  Autor: @ Grupp 1
 *  Version @1.0
 *  marcuswelin88@gmail.com
 */
namespace Info
{
    /*Abstract Super klass. Skapar en ny person med namn och ett ID.*/
    public abstract class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }
        private static int IDCounter = 1;
        private List<string> names = new List<string>() { "Johan", "Camilla", "Sofie", "Gunnar", "Björn", "Amanda" };

        public Person()/*Slumpar fram ett nytt namn, och ID ökar för varje ny instansiering av personklassen.*/
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
