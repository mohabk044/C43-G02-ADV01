using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Point : IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString()
        {
            return $"X = {X} , Y = {Y}";
        }

        public int CompareTo(object? obj)
        {
            Point? point = obj as Point;
            if (X == point?.X)
            {
                return Y.CompareTo(point?.Y);
            }
            else
            {
                return X.CompareTo(point?.X);
            }
        }
    }
}
