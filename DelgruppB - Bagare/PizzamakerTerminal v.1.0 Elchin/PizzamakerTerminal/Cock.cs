using System;
using System.Collections.Generic;

namespace PizzamakerTerminal
{
    class Cock
    {
        // Inloggningsmeny för bagare
        public static void LogIn()
        {
        Console.WriteLine("\nVälkommen till Pizzeria Palatsen!");

            // do-while loop dyker så länge upp tills användaren inmater korrekta uppgifter 
            do
            {
                // Inlogningsinformation visas på skärmen som hjälpmedel
                    Console.WriteLine("\t\t\t\t\t\t\t\t\tInlogningsinformation: ");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\tanvändernamn: user1 >> lösenord: 1111");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\tanvändernamn: user2 >> lösenord: 2222");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\tanvändernamn: user3 >> lösenord: 3333");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\tanvändernamn: user4 >> lösenord: 4444");

                // Tar input uppgifter från bagare
                    Console.Write("\nSkriv ditt användarnamn: ");
                    string username = Console.ReadLine();
                    Console.Write("Ange lösenord: ");
                    string password = Console.ReadLine();

                // Programmet kollar upp vilken bagare som loggar in
                    if (username == "user1" && password == "1111")
                    {
                    Console.Clear();
                        Console.WriteLine("Välkommen User1.\n\nTryck på någon knapp att komma till beställningsmenyn");
                    Console.ReadKey();
                        User.OrderTerminal();
                    }
                    else if (username == "user2" && password == "2222")
                    {
                    Console.Clear();
                    Console.WriteLine("Välkommen User2.\n\nTryck på någon knapp att komma till beställningsmenyn");
                    Console.ReadKey();
                    User.OrderTerminal();
                }
                    else if (username == "user3" && password == "3333")
                    {
                    Console.Clear();
                    Console.WriteLine("Välkommen User3.\n\nTryck på någon knapp att komma till beställningsmenyn");
                    Console.ReadKey();
                    User.OrderTerminal();
                }
                    else if (username == "user4" && password == "4444")
                    {
                    Console.Clear();
                    Console.WriteLine("Välkommen User4.\n\nTryck på någon knapp att komma till beställningsmenyn");
                    Console.ReadKey();
                    User.OrderTerminal();
                }
                    else
                    {
                        Console.WriteLine("\nFelaktig användarnamn eller lösenord. Försök igen");
                    Console.ReadKey();
                    Console.Clear();
                    LogIn();
                    }
            } while (false);

        }
    }
}
