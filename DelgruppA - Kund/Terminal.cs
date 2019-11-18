using System;
using System.Collections.Generic;
using System.Text;
using static KundTermiPizzaPalatset.Pizza;
using System.Threading;



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
            Console.WriteLine();
            ConsoleKeyInfo info; //= Console.ReadKey(true);

			bool done = false;
			while (!done)
			{
                info = Console.ReadKey(true);

                if (info.KeyChar.ToString() == "1")
                {

                    return 1;
                }
                else if (info.Key == ConsoleKey.D2)
                {
                    return 2;
                }
                else if (info.Key == ConsoleKey.D3)
                {
                    return 3;
                }
                else if (info.Key == ConsoleKey.D4)
                {
                    return 4;
                }
                else if (info.Key == ConsoleKey.D5)
                {
                    return 5;
                }
                else if (info.Key == ConsoleKey.D6)
                {
                    return 6;
                }
                else if (info.Key == ConsoleKey.D7)
                {
                    return 7;
                }
                else if (info.Key == ConsoleKey.D8)
                {
                    return 8;
                }
                else if (info.Key == ConsoleKey.D9)
                {
                    return 9;
                }
                else if (info.Key == ConsoleKey.D0)
                {
                    return 0;
                }
                else
                {
                    Console.WriteLine("\t\t\t\t\tFelaktig inmatning! försök igen:");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                    Console.WriteLine("                                                                                                       ");
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                    continue;
                }
			}
			return 0;  //return input;
			//return input;
		} //tryparse readkey
		
		
	}

}
