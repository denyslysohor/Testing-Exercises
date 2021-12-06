using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingContainer
{
    // Class for IComparable, IComparer
    public class Laptop : IComparable<Laptop>
    {
        public string Manufacturer { get; set; }
        public int CountOfCPUs { get; set; }
        public decimal Price { get; set; }

        public Laptop(string manufacturer, int countOfCPUs, decimal price)
        {
            Manufacturer = manufacturer;
            CountOfCPUs = countOfCPUs;
            Price = price;
        }

        public int CompareTo(Laptop? anotherLaptop)
        {
            return Manufacturer.CompareTo(anotherLaptop.Manufacturer);
        }
    }
}
