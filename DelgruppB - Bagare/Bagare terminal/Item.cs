using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelgruppB___Bagare
{

    public class Item
    {
        public int UniqueId { get; set; }           //  from 01 to 99
        public string GroupId { get; set; }         //  ??
        public string Name { get; set; }            //
        public string[] Ingredients { get; set; }   //
        public string Comment { get; set; }         //
        public Timestamp Timestamps;
        private int CurrentState { get; set; }      // 1 - recieved, 2 - started, 3 - finished, 4 - cancelled, 5 - hibernateds 

        public Item()
        {
            Timestamps = new Timestamp();
            Timestamps.Started = DateTime.Now;
            SetAsRecieved();
        }

        public ConsoleColor getStatusColor()
        {
            ConsoleColor[] status_colors = new ConsoleColor[5] { ConsoleColor.Blue, ConsoleColor.DarkYellow, ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.DarkMagenta };
            return status_colors[CurrentState];
        }

        public string getStatus()
        {
            string[] status_strings = new string[5] { "Recieved", "Started", "Finished", "Cancelled", "On Hold" };
            return status_strings[CurrentState];
        }

        public void UpdateState()
        {
            CurrentState = CurrentState < 4 ? CurrentState + 1 : 0;
            //SetState(j);
            Queue.isUpdated = true;
        }
        private void SetState(int n)
        {
            CurrentState = n;
        }
        public void SetAsRecieved()
        {
            SetState(0);
        }
        public void SetAsStarted()
        {
            SetState(1);
        }
        public void SetAsFinished()
        {
            SetState(2);
        }
        public void SetAsCancelled()
        {
            SetState(3);
        }
        public void SetAsOnHold()
        {
            SetState(4);
        }
    }
}
