using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DelgruppB___Bagare
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            bool isLoggedIn = false;
            string SUPER_SECRET_PASSWORD = "hunter12";

            while(isLoggedIn != true)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Enter your password : \t\t\n");
                string input = Console.ReadLine();
                if(input == SUPER_SECRET_PASSWORD)
                {
                    isLoggedIn = true;
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                }
            }

            // Settings
            Config.ConfigurateConsole();
            Config.SetEnvironment();

            Generator generator = new Generator();
            generator.Initiate();

            var key = new ConsoleKeyInfo().KeyChar;
            do
            {
                // Loop som väntar på att knapp trycks
                while (Console.KeyAvailable == false)
                {
                    if (Queue.isUpdated)
                    {
                        Queue.DisplayItems();
                        Queue.isUpdated = false;
                    }
                    System.Threading.Thread.Sleep(20);
                }
                // Allt nedanför körs bara efter knapptryck, annars en evig loop'
                //--------------------------------
                key = Console.ReadKey(true).KeyChar;
                string key_string = key.ToString();
                Regex nums = new Regex(@"[1-9]");

                if(nums.IsMatch(key_string))
                {
                    
                    int k = Int32.Parse(key_string);
                    Queue.UpdateItem(k);
                }



            } while (key != 'q');
        }
    }
}
