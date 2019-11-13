using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelgruppB___Bagare
{
    public class Timestamp
    {
        // Beställd av kunden//Påbörjad påbörjad av employee//Ordern färdigställd och markerad av employee// When change has occured
        
        public DateTime Ordered
        {
            get => Ordered;
            set { Ordered = value; OnUpdate(); }
        }
        public DateTime Started
        {
            get => Started;
            set { Started = value; OnUpdate(); }
        }
        public DateTime Proccessed
        {
            get => Proccessed;
            set { Ordered = value; OnUpdate(); }
        }
        public DateTime UpdatedAt
        {
            get;
            set;
        }

        private void OnUpdate()
        {
            UpdatedAt = DateTime.Now;
        }

        public static string GenerateStamp(string dateFormat = "hh:mm:ss")
        {
            DateTime now = DateTime.Now;
            return now.ToString(dateFormat);
        }
    }
}
