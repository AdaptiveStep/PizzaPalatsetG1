using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Autor: @ Grupp 1
 *  Version @1.0
 *  jonathan.harlin@icloud.com
 */
namespace Cashier
{
    class Program
    {
        //Implementera Buffersize för konsolen
        static void Main(string[] args)/*Startar upp kassörskans terminal.*/
        {
            CashierMenu cashierMenu = new CashierMenu();
            cashierMenu.Run();
        }
    }
}
