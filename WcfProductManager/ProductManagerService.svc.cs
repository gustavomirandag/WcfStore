using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfProductManager.Models;

namespace WcfProductManager
{
    public class ProductManagerService : IProductManagerService
    {
        private static List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public Product[] GetAllAvaiableProducts()
        {
            return products.Where(p => p.Quantity > 0).ToArray();
        }
    }
}
