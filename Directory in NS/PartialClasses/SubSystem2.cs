using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    public partial class SubSystem
    {
        public string currentOwner;

        public SubSystem(string owner)
        {
            currentOwner = owner;
        }
    }
}
