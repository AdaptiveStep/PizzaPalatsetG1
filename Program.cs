using System;
using System.Text.RegularExpressions;
using System.Reflection;

namespace PizzaPalatsetG1
{
    class Program
    {
        static void Main(string[] args)
        {
            string arg = "";
            try
            {
                //
                //  Uppsatt för att använda den spännande 'args'-parametern
                //  FInns flera sätt att lägg till argument, 
                //      -   Skapa en shortcut till /bin/.exe högerklicka den nya shortcuten och 
                //          lägg till ett ord efter i "start in"-fältet
                //      - Höger klicka projektet i visual studio sedan properties/debug/ och fyll command line args
                //
                if (args.Length < 1)
                {
                    InputLoop($"Saknar startargumnet. Ange manuellt 'order', 'kund', 'master', front' etc");
                }
                else
                {
                    arg = args[0];
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.Write("Rätt .exe filer ej tillagda. Saknar startargument");
            }
            catch (System.Exception)
            {
                Console.Error.Write("Error occured ¯\\_(ツ)_/¯\n");
                throw;
            }
        }

        private string InputLoop(string msg)
        {
            Console.Write($"{msg}");
            var console_input = Console.ReadLine();
            arg = console_input.Substring(0, 1).ToUpper() + console_input.Substring(1);  // Första bokstaven till stor ex "order" => "Order"
            switch (arg)
            {
                case "Front":
                    Terminal terminal = new FrontTerminal();
                    terminal.Run();
                    break;
                case "Master":
                    Terminal terminal = new MasterTerminal();
                    terminal.Run();
                    break;
                case "Order":
                    Terminal terminal = new OrderTerminal();
                    terminal.Run();
                    break;
                case "Process":
                    Terminal terminal = new ProcessTerminal();
                    terminal.Run();
                    break;
                case "Debug":
                    this.quit();
                    break;
                default:
                    InputLoop($"'{arg}' is wrong. Ange manuellt 'order', 'kund', 'master', front' etc");
            }
        }
    }
}
