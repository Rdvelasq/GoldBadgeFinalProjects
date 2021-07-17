using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Product
    {
        private string Name;
        private int quantity;

        public Product(string name, int quantity)
        {
            this.Name = name;
            Quantity(quantity);
        }

        public int Quantity(int quantity)
        {
            if (quantity < 1)
            {
                return this.quantity = 1;
            }
            return this.quantity = quantity;
        }
    }
}
