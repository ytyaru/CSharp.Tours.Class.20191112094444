using System;

namespace Tours.Lesson2
{
    public class Point3D : Point
    {
        public int z;
        public Point3D(int x, int y, int z) : base(x,y) => this.z = z;
    }
}
