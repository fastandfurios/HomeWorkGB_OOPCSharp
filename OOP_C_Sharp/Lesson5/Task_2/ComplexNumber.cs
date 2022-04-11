using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.Task_2
{
    public readonly partial struct ComplexNumber
    {
        private readonly double _a;
        private readonly double _b;

        public ComplexNumber(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public override string ToString() => _b < 0 ? $"{_a}{_b}i" : $"{_a}+{_b}i";
    }
}
