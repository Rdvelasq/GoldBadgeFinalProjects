using Burger_Booth_POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger_Booth_Repo
{
    public class BurgerBoothRepo
    {
        private BurgerBooth _burger = new BurgerBooth(6.00m, 4.50m, 3.00m, 50, 0, 0);
        public  BurgerBooth MakeBurgerBoothMenu()
        {
            return _burger;
        }
        public void ProcessOrder(decimal userWants)
        {
            _burger.TotalCost += userWants;
            _burger.Ticket++;
        }
        public int GetTickets() => _burger.Ticket;
        public decimal GetTotalCost() => _burger.TotalCost;

    }
}
