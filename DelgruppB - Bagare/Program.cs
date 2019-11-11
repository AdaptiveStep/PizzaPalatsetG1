using System;
using System.Text.RegularExpressions;


namespace DelgruppB___Bagare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Settings
            Console.CursorVisible = false;
            //
            OrderWatcher watcher = new OrderWatcher();

            var key = new ConsoleKeyInfo().KeyChar;
            do
            {
                if(watcher.HasNewOrder()){
                    var time_stamp = DateTime.Now.ToString("HH:mm:ss");
                    Console.Write($"New order at {time_stamp}");
                }
                // Loop som väntar på att knapp trycks
                while (Console.KeyAvailable == false)
                {
                    System.Threading.Thread.Sleep(20);
                }
                // Allt nedanför körs bara efter knapptryck, annars en evig loop'
                //--------------------------------
                key = Console.ReadKey(true).KeyChar;

                var regex = new Regex(@"[1-9]");
                Console.Beep();
                Console.Write("x");


            } while (key != 'q');
        }
    }
}
