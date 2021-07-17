using Burger_Booth_POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treat_Booth_POCO;

namespace BBQ_POCO
{
    public class BBQ
    {
        public int TotalTickets { get; set; }
        public decimal TotalCost { get; set; }
        public BurgerBooth BurgerBooth { get; set; }
        public TreatBooth TreatBooth { get; set; }
        public BBQ()
        {

        }
        public BBQ(int totalTickets, decimal totalCost, BurgerBooth burgerBooth, TreatBooth treatBooth)
        {
            TotalTickets = totalTickets;
            TotalCost = totalCost;
            BurgerBooth = burgerBooth;
            TreatBooth = treatBooth;
        }
    }
}
