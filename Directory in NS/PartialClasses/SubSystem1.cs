using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    public partial class SubSystem
    {
        public string nameOfSubSystem;
        public int countOfGroups;

        public SubSystem(string name, int count)
        {
            nameOfSubSystem = name;
            countOfGroups = count;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name of Current SubSystem: {nameOfSubSystem}");
            Console.WriteLine($"Total count of groups in {nameOfSubSystem} - {countOfGroups}");
            Console.WriteLine($"Current owner: {currentOwner}");
        }
    }
}
