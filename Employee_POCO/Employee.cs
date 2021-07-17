using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_POCO
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int BurgerBoothTicket { get; set; }
        public int TreatBoothTicket { get; set; }
        public Employee()
        {

        }
        public Employee(int id, string name, int burgerBoothTicket, int treatBoothTicket)
        {
            ID = id;
            Name = name;
            BurgerBoothTicket = burgerBoothTicket;
            TreatBoothTicket = treatBoothTicket;
        }
    }

}
