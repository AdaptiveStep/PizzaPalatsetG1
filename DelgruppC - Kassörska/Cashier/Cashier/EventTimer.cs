using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Timers;

namespace Cashier
{
    public class EventTimer
    {
        public event Action CompleteOrder;

        public EventTimer()
        {
            Timer timer = new Timer(1000 * 3);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (CompleteOrder != null)
            {
                CompleteOrder();
            }
        }
    }
}
