using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManagement
{
    internal class Electronic : IProduct
    {
       public int WarrantyInMonths { get; private set; }
       public string Name { get; set; }
       public double Price { get; set; }
       public void PrintInfo()
       {
           Console.WriteLine($"Name: {Name}");
           Console.WriteLine($"Price: {Price}");
           Console.WriteLine($"Warranty months: {WarrantyInMonths}");
        }

       public Electronic(string name, double price, int warrantyInMonths)
       {
           Name = name;
           Price = price;
           WarrantyInMonths = warrantyInMonths;
       }
    }
}
