using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier
{
    class Program
    {
        static void Main(string[] args)
        {
            CashierMenu cashierMenu = new CashierMenu();
            cashierMenu.Run();
        }
    }
}
