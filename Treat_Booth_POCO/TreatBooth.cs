using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treat_Booth_POCO
{
    public class TreatBooth
    {
        public decimal Popcorn { get; set; }
        public decimal IceCream { get; set; }
        public decimal Misc { get; set; }
        public decimal TotalCost { get; set; }
        public int Ticket { get; set; }
        public TreatBooth()
        {

        }
        public TreatBooth(decimal popcorn, decimal iceCream, decimal misc, decimal totalCost, int ticket)
        {
            Popcorn = popcorn;
            IceCream = iceCream;
            Misc = misc;
            TotalCost = totalCost;
            Ticket = ticket;
        }
    }
}
