using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelgruppB___Bagare
{
    public delegate Item FetchFakeData(int x, int y);

    class Generator
    {
        public event FetchFakeData FakeDataEvent;
        private System.Threading.Timer timer;
        private Random rand;
        private int min = 3000;
        private int max = 13000;

        public void Initiate()
        {
            this.FakeDataEvent += RandomMachine.CreateRandomItem;
            rand = new Random(Environment.TickCount);
            timer = new System.Threading.Timer(TimerEvent, null, rand.Next(min, max), System.Threading.Timeout.Infinite);
        }

        private void TimerEvent(object state)
        {
            //callback();
            Item newItem = FakeDataEvent.Invoke(1, 2);
            timer.Change(rand.Next(min, max), System.Threading.Timeout.Infinite);
        }
    }
    struct RandomMachine
    {
        public static Item CreateRandomItem(int itemsInOrder, int y)
        {
            Item newItem = new Item();

       
            return newItem;
        }


    }
}
