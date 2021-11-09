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
        private readonly IList<(double x, double y)> _vertexes = new List<(double, double)>();

        public override string ToString()
            => $"Прямоугольник с вершинами: {GetEntry()}";

        private string GetEntry()
        {
            string entry = string.Empty;

            foreach (var vertex in _vertexes)
            {
                entry += vertex + " ";
            }

            return entry;
        }

        public override void GetArea()
        {
            if (_vertexes.Count == 4)
            {
                var a = _vertexes[0];
                var b = _vertexes[1];
                var c = _vertexes[2];
                var width = Abs(Sqrt((b.y - a.y) * (b.y - a.y) + (b.x - a.x) * (b.x - a.x)));
                var height = Abs(Sqrt((c.y - a.y) * (c.y - a.y) + (c.x - a.x) * (c.x - a.x)));
                Console.WriteLine($"Площадь прямоугольника: {Round(width * height, 2)}");
            }
        }

        public override ConsoleColor Color { set => _color = value; }
        public override bool IsVisible { set => _isVisible = value; }
        public override (double, double) Coordinates { set => _vertexes.Add(value); }
    }
}
