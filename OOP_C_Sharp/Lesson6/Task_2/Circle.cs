using System;
using System.Collections.Generic;
using System.Linq;
using static System.Math;

namespace Lesson6.Task_2
{
    public class Circle : Point
    {
        private ConsoleColor _color;
        private bool _visible;
        private List<(double x, double y)> _coordinates = new(2);
        private double _radius;

        public override string ToString()
            => $"Окружность с центром в точке с координатами: {_coordinates[0]}, радиусом R = {_radius} и площадью {GetArea()}\n" +
               $"Цвет: {_color}, видимость: {_visible}";

        public override void AxisShift(int x = 0, int y = 0)
            => _coordinates = _coordinates.Select(c => (c.x + x, c.y + y)).ToList();

        protected override double GetArea()
        {
            if(_coordinates.Count == 2)
            {
                var a = _coordinates[0];
                var b = _coordinates[1];
                _radius = Abs(Sqrt((b.y - a.y) * (b.y - a.y) + (b.x - a.x) * (b.x - a.x)));
                return Round(_radius * _radius * PI, 2);
            }

            return base.GetArea();
        }

        public override ConsoleColor Color { set => _color = value; }
        public override bool Visible { set => _visible = value; }
        public override (double X, double Y) Coordinates { set => _coordinates.Add(value); }
    }
}
