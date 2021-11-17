using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    internal class TupleDec
    {
        public (string, int) TupleDeconstruct(string progLang)
        {
            if (progLang == "C#")
            {
                return ("Microsoft", 2001);
            }
            else if (progLang == "Swift")
            {
                return ("Apple", 2014);
            }

            return ("", 0);
        }
    }
}
