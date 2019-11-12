using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelgruppB___Bagare
{
    public delegate int PerformCalculation(int x, int y);

    class Generator
    {
        event PerformCalculation MyEvent;
        private System.Threading.Timer timer;
        private Random rand;
        private int min = 3000;
        private int max = 13000;

        public void Initiate()
        {
            this.MyEvent += Add;
            rand = new Random(Environment.TickCount);
            timer = new System.Threading.Timer(TimerEvent, null, rand.Next(min, max), System.Threading.Timeout.Infinite);
        }

        private void TimerEvent(object state)
        {
            //callback();
            int r = this.MyEvent.Invoke(1, 2);
            Console.Write(r);
            timer.Change(rand.Next(min, max), System.Threading.Timeout.Infinite);
        }

        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
