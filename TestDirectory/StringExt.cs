using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public static class StringExt
    {
        public static int ToCharacterCount(this string myString)
        {
            var internalVariable = myString.ToCharArray();
            int result = internalVariable.Length;

            return result;
        }
    }
}
