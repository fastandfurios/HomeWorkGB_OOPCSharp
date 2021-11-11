using System;

namespace Lesson7.Task_2
{
    public class Point : Figure
    {
        private (double x, double y) _coordinates;
        private ConsoleColor _color;
        private bool _visible;

        public virtual (double X, double Y) Coordinates { set => _coordinates = value; }
        public override ConsoleColor Color { set => _color = value; }
        public override bool Visible { set => _visible = value; }

        public override string ToString() => $"Точка с координатами ({_coordinates.x}:{_coordinates.y}), цвет {_color}, видимость {_visible}";
        public override void AxisShift(int x = 0, int y = 0) => _coordinates = (_coordinates.x + x, _coordinates.y + y);
    }
}
