using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelgruppB___Bagare
{
    public class Timestamp
    {

        /// <summary>
        /// När beställningen är skickad från kund. 
        /// </summary>
        public DateTime Ordered;
        /// <summary>
        /// Markerad som påbörjad av employee.
        /// </summary>
        public DateTime Started;
        /// <summary>
        ///  Ordern färdigställd och markerad av employee.
        /// </summary>
        public DateTime Proccessed;
        /// <summary>
        /// Ny uppdatering när en ändring sker.
        /// </summary>
        public DateTime UpdatedAt;
        private void OnUpdate()
        {
            UpdatedAt = DateTime.Now;
        }
        /// <summary>
        /// Generera timestamp i stringformat.
        /// </summary>
        /// <param name="dateFormat"></param>
        /// <returns></returns>
        public static string GenerateStamp(string dateFormat = "hh:mm:ss")
        {
            DateTime now = DateTime.Now;
            return now.ToString(dateFormat);
        }
    }
}
