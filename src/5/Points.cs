using System;

namespace Tours.Lesson5
{
    public class Points
    {
        public int[] Values { get; private set; }
        public Points(params int[] points) => this.Values = points;
    }
}
