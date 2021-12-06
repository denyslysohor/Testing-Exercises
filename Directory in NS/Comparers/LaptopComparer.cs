using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingContainer
{
    internal class LaptopComparer : IComparer<Laptop>
    {
        public int Compare(Laptop? firstLaptop, Laptop? secondLaptop)
        {
            if (firstLaptop.CountOfCPUs > secondLaptop.CountOfCPUs)
                return 1;
            else if (firstLaptop.CountOfCPUs < secondLaptop.CountOfCPUs)
                return -1;
            else
                return 0;
        }
    }
}
