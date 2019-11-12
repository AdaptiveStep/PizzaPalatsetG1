﻿using System;
using System.Collections.Generic;
using System.Text;
using static KundTermiPizzaPalatset.Pizza;



namespace KundTermiPizzaPalatset
{
    public class Terminal
    {
        internal List<List<Product>> itemRegister = new List<List<Product>>();

        public Terminal()
        {
            //Innehåller standardgreher
            List<Product> pizzor = new List<Product>();
            pizzor.Add(new Pizza ("Capricosa"));
            pizzor.Add(new Pizza ( "Vesuvio"));
            pizzor.Add(new Pizza ( "Vegetarisk", 50));
            pizzor.Add(new Pizza ( "Mexicana"));
            pizzor.Add(new Pizza ( "Hawaii"));
            pizzor.Add(new Pizza ( "Salami"));
            itemRegister.Add(pizzor);

            //ANALogt
            List<Product> pasta = new List<Product>();
            pasta.Add(new Pasta ("Carbonara", 75));
            pasta.Add(new Pasta ("Frutti di mare", 75));
            pasta.Add(new Pasta ("Pesto", 75));
            pasta.Add(new Pasta ("Mustafas krämiga Oxfilé"));
            itemRegister.Add(pasta);

            //etc
            List<Product> sallad = new List<Product>(); //todo
            sallad.Add(new Sallad ("Räksallad"));
            sallad.Add(new Sallad ("Fetaost-sallad"));
            sallad.Add(new Sallad ("Ceasarsallad"));
            sallad.Add(new Sallad ("Kycklingsallad"));
            itemRegister.Add(sallad);

            List<Product> tillbehör = new List<Product>(); //todo
            tillbehör.Add(new Tillbehör("Läsk, 33cl"));
            tillbehör.Add(new Tillbehör("Läsk, 2L"));
            tillbehör.Add(new Tillbehör("Dippsås, Bearnaise"));
            tillbehör.Add(new Tillbehör("Dippsås, Vitlök"));
            tillbehör.Add(new Tillbehör("Stor Stark"));
            tillbehör.Add(new Tillbehör("Vin 40cl: Vitt"));
            tillbehör.Add(new Tillbehör("Vin 40cl: Rött"));  //todo bank id, eventuell ny lista
            itemRegister.Add(tillbehör);
            //tillbehör.Add(new Tillbehör ("Ost")); //todo
            //tillbehör.Add(new Tillbehör ("Skinka"));
            //tillbehör.Add(new Tillbehör ("Oliver"));
            //tillbehör.Add(new Tillbehör ("Jalapeño"));
            //tillbehör.Add(new Tillbehör ("Ananas"));
            //tillbehör.Add(new Tillbehör ("Lök"));
            //tillbehör.Add(new Tillbehör ("Räkor"));
            //tillbehör.Add(new Tillbehör ("Champinjoner"));


            List<Order> ordrar = new List<Order>();
            List<Customer> customers = new List<Customer>();
          
        }
 


        public static int  IntIn()
        {
            Int32.TryParse(Console.ReadLine(), out int input);

            bool done = false;
            //int input = Convert.ToInt32(Console.ReadLine());
            while (!done)
            {
                try
                {
                    
                    done = true;
                    return input;

                }
                catch(FormatException e)
                {
                    Console.WriteLine("Nått gick galet, försök igen!", e.Message);
                    
                }

               
            }
 return input;
            //return input;
        } //tryparse readkey
        
        
    }

}
