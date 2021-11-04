using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.Task_2
{
    public readonly partial struct ComplexNumber
    {
        #region operation Sum
        public static ComplexNumber operator +(ComplexNumber x, ComplexNumber y) => new(x._a + y._a, x._b + y._b);
        #endregion

        #region operation Sub
        public static ComplexNumber operator -(ComplexNumber x, ComplexNumber y) => new(x._a - y._a, x._b - y._b);
        #endregion

        #region operation Inc
        public static ComplexNumber operator *(ComplexNumber x, ComplexNumber y)
        {
            var a = new ComplexNumber(x._a * y._a, x._b * y._a);
            var b = new ComplexNumber(-1 * x._b * y._b,  x._a * y._b);
            return a + b;
        }
        #endregion

        #region operations Equality
        public override bool Equals(object obj)
            => obj!.ToString() == ToString();

        public override int GetHashCode()
            => ToString().GetHashCode();

        public static bool operator ==(ComplexNumber x, ComplexNumber y) => x._a.Equals(y._a) && x._b.Equals(y._b);
        public static bool operator !=(ComplexNumber x, ComplexNumber y) => !x._a.Equals(y._a) && !x._b.Equals(y._b);
        #endregion
    }
}
