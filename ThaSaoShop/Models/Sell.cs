using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaSaoShop.Models
{
    public class Sell
    {
        public Sell() { }

        public Sell(Product product, int amount)
        {
            Product = product;
            Amount = amount;
        }

        public Product Product { get; set; }
        public int Amount { get; set; }
        public int Total => Product.Price * Amount;
    }
}
