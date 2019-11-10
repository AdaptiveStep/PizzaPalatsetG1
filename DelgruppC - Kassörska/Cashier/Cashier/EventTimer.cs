using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Timers;

namespace Cashier
{
    public class EventCompleteOrder
    {
        public ConsoleKeyInfo keyInfo;
        

        public event EventHandler KeyPressed;

        protected virtual void OnKeyPressed()
        {
            if (KeyPressed != null)
            {
                KeyPressed(this, EventArgs.Empty);
            }
        }
        public void Key(XKeyPressed xKeyPressed)
        {
            Console.KeyAvailable.CompareTo
        }
    }
    public class XKeyPressed
    {
        public void XKey()
        {
            ConsoleKeyInfo keyInfo;
            keyInfo.Key = ConsoleKey.X;
        }
    }
}
