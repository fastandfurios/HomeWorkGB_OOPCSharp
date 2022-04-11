using System;

namespace Lesson6.Task_2
{
    public class Figure
    {
        private ConsoleColor _color;
        private bool _visible;

        /// <summary> Сдвигает фигуру по осям Х и Y </summary>
        /// <param name="x">координата x</param>
        /// <param name="y">координата y</param>
        public virtual void AxisShift(int x = 0, int y = 0) { }

        /// <summary> Меняет цвет фигуры </summary>
        /// <param name="color"></param>
        public virtual ConsoleColor Color { set => _color = value; }
        
        /// <summary> Meняет видимость фигуры </summary>
        public virtual bool Visible { set => _visible = value; }

        /// <summary> Возвращает площадь фигуры </summary>
        protected virtual double GetArea() { throw new ArgumentException("Площадь не будет рассчитана, т.к. не были заданы все точки!"); }
    }
}
