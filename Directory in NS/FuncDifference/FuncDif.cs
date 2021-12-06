using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDifference
{
    internal class FuncDif
    {
        // Explicit Method
        public static double MultipleFunc(int parameter1, int parameter2)
        {
            return parameter1 * parameter2;
        }

        // The instance of anonymous method

        public delegate double MultipleDelegate(int parameter1, int parameter2);
        public static double Multiple(int parameter1, int parameter2)
        {
            return (parameter1 * parameter2);
        }

    }
}
