using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicine
{
    public class Drug
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Drug(string name, int quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}
