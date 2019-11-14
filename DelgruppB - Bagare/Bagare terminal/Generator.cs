using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelgruppB___Bagare
{
    public delegate bool FetchFakeData(int x, int y);

    class Generator
    {
        public event FetchFakeData FakeDataEvent;
        private System.Threading.Timer timer;
        public static Random rand;
        private int min = 3000;
        private int max = 5000;

        public void Initiate()
        {
            this.FakeDataEvent += RandomMachine.CreateRandomItem;
            rand = new Random(Environment.TickCount);
            timer = new System.Threading.Timer(TimerEvent, null, rand.Next(min, max), System.Threading.Timeout.Infinite);
        }

        private void TimerEvent(object state)
        {
            //callback();
            int n = rand.Next(0, 4);
            FakeDataEvent.Invoke(n, 2);
            timer.Change(rand.Next(min, max), System.Threading.Timeout.Infinite);
        }
    }
    struct RandomMachine
    {

        public static bool CreateRandomItem(int n, int y)
        {
            string group_id = GenUniqueGroupId();

            for (var j = 0; j < n; j++)
            {
                Item newItem = new Item();
                newItem.Name = "[Name here]";
                newItem.GroupId = group_id;
                newItem.Ingredients = new string[3]{ "a", "b", "c"};

                Queue.AddItem(newItem);

            }

            return true;
        }

        private static string GenUniqueGroupId()
        {
            Guid id = Guid.NewGuid();
            return id.ToString();
        }
    }
}
