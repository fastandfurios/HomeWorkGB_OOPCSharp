using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Lesson6.Task_2
{
    public class Rectangle : Point
    {
        private ConsoleColor _color;
        private bool _isVisible;
        private List<(double x, double y)> _vertexes = new(4);
        private double _height, _width;

        public override string ToString()
            => $"Прямоугольник с вершинами в точках: {GetEntry()}\nВысота = {_height}, ширина = {_width}\n" +
               $"Цвет: {_color}, видимость: {_isVisible}\n" +
               $"Площадь = {GetArea()}";

        private StringBuilder GetEntry()
        {
            var entry = new StringBuilder();

            foreach (var vertex in _vertexes)
            {
                entry.Append(vertex + " ");
            }

            return entry;
        }

        protected override double GetArea()
        {
            if (_vertexes.Count == 4)
            {
                var a = _vertexes[0];
                var b = _vertexes[1];
                var c = _vertexes[2];
                _width = Abs(Sqrt((b.y - a.y) * (b.y - a.y) + (b.x - a.x) * (b.x - a.x)));
                _height = Abs(Sqrt((c.y - a.y) * (c.y - a.y) + (c.x - a.x) * (c.x - a.x)));
                return Round(_width * _height, 2);
            }

            return base.GetArea();
        }

        public override void AxisShift(int x = 0, int y = 0) 
            => _vertexes = _vertexes.Select(vertex => (vertex.x+x,vertex.y+y)).ToList();

        public override ConsoleColor Color { set => _color = value; }
        public override bool Visible { set => _isVisible = value; }
        public override (double, double) Coordinates { set => _vertexes.Add(value); }
    }
}
