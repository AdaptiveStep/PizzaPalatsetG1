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
        public Timestamp Timestamps { get; set; }   //
        private int CurrentState { get; set; }      // 1 - recieved, 2 - started, 3 - finished, 4 - cancelled, 5 - hibernateds 

        public Item()
        {
            Timestamps.Started = DateTime.Now;
            SetState(1);
        }   

        private void SetState(int n)
        {
            CurrentState = n;
        }

        public void SetAsStarted()
        {
            SetState(2);
        }
        public void SetAsFinished()
        {
            SetState(3);
        }
        public void SetAsCancelled()
        {
            SetState(4);
        }
        public void SetAsOnHold()
        {
            SetState(5);
        }

    }

}
