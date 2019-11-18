using System;
using System.Linq;

namespace PizzamakerTerminal
{
    class Cock
    {
        // Inloggningsmeny för bagare
        public static void LogIn()
        {
            string[] users = new string[4] { "user1", "user2", "user3", "user4" };
            string[] passwds = new string[4] { "1111", "2222", "3333", "4444" };
            // do-while loop dyker så länge upp tills användaren inmater korrekta uppgifter 
            //Console.WriteLine("\t\t\t\t\t\t\t\t\tInlogningsinformation: ");
            //for (int i = 0; i < users.Length; i++)
            //{
            //    Console.WriteLine("\t\t\t\t\t\t\t\t\tanvändernamn: {0} >> lösenord: {1}", users[0], users[1]);
            //}
            // Tar input uppgifter från bagare
            Console.Write("\nSkriv ditt användarnamn: ");
            string username = Console.ReadLine();
            Console.Write("Ange lösenord: ");
            string password = Console.ReadLine();

            // Programmet kollar upp vilken bagare som loggar in
            if (users.Contains(username) && passwds.Contains(password))
            {
                Console.Clear();
                Status.IsLoggedIn = true;
                Status.CurrentUserId = Array.IndexOf(users, username); // Assignar userid
                Status.CurrentUserName = users[Status.CurrentUserId];
                //int x = Array.IndexOf(users, username);
                //user = x;
                //User.OrderTerminal(user);
            }
            else if (username == "0" || password == "0")
            {
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("\nFelaktig användarnamn eller lösenord. Försök igen");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void Logout()
        {
            Status.IsLoggedIn = false;
        }
    }
}
