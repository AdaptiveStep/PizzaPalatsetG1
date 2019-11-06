using System;
using System.Collections.Generic;
using System.Text;

namespace InfoSkärmar
{
    public class CashierMenu
    {
        private string _password = "Password123";
        public bool Login()
        {
            do
            {
                Console.Write("Skriv in Lösenord: ");
                string passwordCandidate = Console.ReadLine();

                if (passwordCandidate == _password)
                {
                    return true;
                }
                Console.Clear();
            } while (true);
        }
    }
}
