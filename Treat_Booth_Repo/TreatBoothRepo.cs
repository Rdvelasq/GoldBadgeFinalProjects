using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treat_Booth_POCO;

namespace Treat_Booth_Repo
{
    public class TreatBoothRepo
    {
        TreatBooth treatBooth = new TreatBooth(2.50m, 3.00m, 20m, 0m, 0);
        public TreatBooth CreateTreatBoothMenu()
        {
            return treatBooth;
        }
        public void AddToTotalCost(decimal userWants)
        {
            treatBooth.TotalCost += userWants;
        }
        public void AddToTotalTickets()
        {
            treatBooth.Ticket++;
        }
        public int GetTickets() => treatBooth.Ticket;
        public decimal GetTotalCost() => treatBooth.TotalCost;
    }
}
