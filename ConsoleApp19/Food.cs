using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManagement
{
    internal class Food : IProduct
    {
        public int BestBefore { get; private set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Best before: {BestBefore}");
        }

        public Food(string name, double price, int bestBefore)
        {
            Name = name;
            Price = price;
            BestBefore = bestBefore;
        }
    }
}
