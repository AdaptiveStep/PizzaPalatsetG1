using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Info
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

        public void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (CompleteOrder != null)
            {
                CompleteOrder();
            }
        }
    }
}
