using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManagement
{
    internal class Storage
    {
        private List<IProduct> Products { get; set; } = new List<IProduct>();


        public void AddProduct(IProduct product)
        {
            Products.Add(product);
        }
        public void RemoveProduct(IProduct product)
        {
            Products.Remove(product);
        }
        public void PrintProducts()
        {
            foreach (var product in Products)
            {
                product.PrintInfo();
                Console.WriteLine();
            }
        }
    }
}
