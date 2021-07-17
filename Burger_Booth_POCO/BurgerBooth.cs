using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger_Booth_POCO
{
    public class BurgerBooth
    {
        public decimal VeggieBurger { get; set; }
        public decimal Hamburger { get; set; }
        public decimal HotDog { get; set; }
        public decimal Misc { get; set; }
        public int Ticket { get; set; }
        public decimal TotalCost { get; set; }
        public BurgerBooth()
        {

        }
        public BurgerBooth(decimal veggieBurger, decimal hamburger, decimal hotDog, decimal misc, int ticket, decimal totalCost)
        {
            VeggieBurger = veggieBurger;
            Hamburger = hamburger;
            HotDog = hotDog;
            Misc = misc;
            Ticket = ticket;
            TotalCost = totalCost;
        }
    }
}
