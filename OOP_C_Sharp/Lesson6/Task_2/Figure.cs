using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Task_2
{
    public class Figure
    {
        private ConsoleColor _color;
        private bool _isVisible;

        protected virtual void Invertire(Figure figure, Point point)
        {

        }

        public virtual void GetArea() { }

        public virtual ConsoleColor Color { set => _color = value; }
        public virtual bool IsVisible { set => _isVisible = value; }
    }
}
