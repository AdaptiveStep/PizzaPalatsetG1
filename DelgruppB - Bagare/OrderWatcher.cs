using System;
using System.Text.RegularExpressions;
using System.Timers;

namespace DelgruppB___Bagare
{
    class OrderWatcher
    {
        private DateTime start_time;
        private long start_time_utc;
        private bool hasNewOrder = false;
        public OrderWatcher()
        {
            this.start_time = DateTime.Now; // On invoke
            this.start_time_utc = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            var t = new Timer();
            t.Interval = 1000;  // todo;
            t.Elapsed += GenerateOrder;
            t.AutoReset = true;
            t.Enabled = true;
            // string current_dir = System.Environment.CurrentDirectory;
            // string audio_dir = System.IO.Path.Combine(current_dir, @"audio/beep1.wav");
        }
        private void GenerateOrder(Object source, ElapsedEventArgs e){
            Console.WriteLine("new order generated");
        }
        public bool HasNewOrder()
        {
            return this.hasNewOrder;
        }
    }
}
