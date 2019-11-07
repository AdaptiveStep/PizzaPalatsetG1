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
                    arg = InputLoop($"Saknar startargumnet. Ange manuellt 'order', 'kund', 'master', front' etc \n");
                }
                else
                {
                    arg = args[0];
                }
                switch (arg)
                {
                    case "Front":
                        Terminal a = new FrontTerminal();
                        a.Run();
                        break;
                    case "Master":
                        Terminal b = new MasterTerminal();
                        b.Run();
                        break;
                    case "Order":
                        Terminal c = new OrderTerminal();
                        c.Run();
                        break;
                    case "Process":
                        Terminal d = new ProcessTerminal();
                        d.Run();
                        break;
                    case "Debug":
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.Write("Wrong, quitting for now \n");
                        System.Environment.Exit(0);
                        break;
                        //InputLoop($"'{arg}' is wrong. Ange manuellt 'order', 'kund', 'master', front' etc");
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

        private static string InputLoop(string msg)
        {
            Console.Write($"{msg}");
            var console_input = Console.ReadLine();
            return console_input.Substring(0, 1).ToUpper() + console_input.Substring(1);  // Första bokstaven till stor ex "order" => "Order"
        }
    }
}
