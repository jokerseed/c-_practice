using System;
using System.Collections.Generic;
using System.Text;

namespace demo
{
    class Point3D : Point
    {
        public int Z { get; }
        public Point3D(int x, int y, int z) : base(x, y) {
            Z = z;
        }
    }
}
