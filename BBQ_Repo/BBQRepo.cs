using BBQ_POCO;
using Burger_Booth_POCO;
using Burger_Booth_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treat_Booth_POCO;

namespace BBQ_Repo
{
    public class BBQRepo
    {
        List<BBQ> _bbq = new List<BBQ>();
        public void MakeBBQ(BurgerBooth burgerBooth, TreatBooth treatBooth)
        {
            BBQ bbq = new BBQ(0, 0m, burgerBooth, treatBooth);
            _bbq.Add(bbq);
        }
        public Decimal GetTotalCost()
        {
            BBQ bbq = GetBBQ();
            bbq.TotalCost = bbq.BurgerBooth.TotalCost + bbq.TreatBooth.TotalCost;
            return bbq.TotalCost;
        }
        public int GetTotalTickets()
        {
            BBQ bbq = GetBBQ();
            bbq.TotalTickets = bbq.TreatBooth.Ticket + bbq.BurgerBooth.Ticket;
            return bbq.TotalTickets;
        }
        //Helper
        public BBQ GetBBQ() => _bbq.First<BBQ>();
        
    }
}
