using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Task_2
{
    public class Point : Figure
    {
        private (double x, double y) _coordinates;
        public override string ToString() => $"({_coordinates.x}:{_coordinates.y})";
        public virtual (double X, double Y) Coordinates { set => _coordinates = value; }
    }
}
