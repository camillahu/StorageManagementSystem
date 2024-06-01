using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManagement
{
    internal class Clothing : IProduct
    {
        public string Size { get; private set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Size: {Size}");
        }

        public Clothing(string name, double price, string size)
        {
            Name = name;
            Price = price;
            Size = size;
        }
    }
}
