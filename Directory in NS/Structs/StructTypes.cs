using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructNamespace
{
    internal class StructTypes
    {
        public readonly struct Point
        {
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X { get; init; }
            public double Y { get; init; }

            public override string ToString() => $"(X: {X}, Y: {Y})";
        }
    }
}
