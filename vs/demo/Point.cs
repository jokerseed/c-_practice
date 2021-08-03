using System;
using System.Collections.Generic;
using System.Text;

namespace demo
{
    class Point : BasePoint
    {
        public int X { get; }
        public int Y { get; }
        public Point(int x, int y) => (X, Y) = (x, y);
    }
}
