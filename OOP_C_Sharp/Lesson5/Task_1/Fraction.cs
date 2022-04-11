using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.Task_1
{
    public readonly partial struct Fraction
    {
        private readonly double _numerator;
        private readonly double _denominator;

        public Fraction(double numerator, double denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не должен быть равен нулю");
            }

            _numerator = numerator;
            _denominator = denominator;
        }

        public override string ToString() => $"{_numerator}/{_denominator}";
    }
}
