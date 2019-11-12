using System;

namespace Tours.Lesson1
{
    public class Point<T>
    {
        public T x, y;
        public Point(T x, T y) => (this.x, this.y) = (x, y);
    }
}
