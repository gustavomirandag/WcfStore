using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfProductManager.Models
{
    public class Product
    {
        public Product()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}