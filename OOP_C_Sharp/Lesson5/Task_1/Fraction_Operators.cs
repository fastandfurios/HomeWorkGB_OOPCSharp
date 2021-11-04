using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Lesson5.Task_1
{
    public readonly partial struct Fraction
    {
        #region operations Sum 
        public static Fraction operator +(Fraction a, double b) => new(a._numerator * b + b * a._denominator, a._denominator);

        public static Fraction operator +(double a, Fraction b) => new(b._numerator * a + a * b._denominator, b._denominator);

        public static Fraction operator +(Fraction a, Fraction b) => new(a._numerator * b._denominator + b._numerator * a._denominator, a._denominator * b._denominator);

        public static Fraction operator ++(Fraction a) => new(a._numerator * 1 + 1 * a._denominator, a._denominator);
        #endregion

        #region operations Sub
        public static Fraction operator -(Fraction a, double b) => new(a._numerator * b - b * a._denominator, a._denominator);

        public static Fraction operator -(double a, Fraction b) => new(b._numerator * a - a * b._denominator, b._denominator);

        public static Fraction operator -(Fraction a, Fraction b) => new(a._numerator * b._denominator - b._numerator * a._denominator, a._denominator * b._denominator);

        public static Fraction operator -(Fraction a) => new(-a._numerator, a._denominator);

        public static Fraction operator --(Fraction a) => new(a._numerator * 1 - 1 * a._denominator, a._denominator);
        #endregion

        #region operations Inc
        public static Fraction operator *(Fraction a, double b) => new(a._numerator * b, a._denominator);

        public static Fraction operator *(double a, Fraction b) => new(b._numerator * a, b._denominator);

        public static Fraction operator *(Fraction a, Fraction b) => new(a._numerator * b._numerator, a._denominator * b._denominator);
        #endregion

        #region operations Div
        public static Fraction operator /(Fraction a, double b) => new(a._numerator * b, a._denominator);

        public static Fraction operator /(double a, Fraction b) => new(b._numerator * a, b._denominator);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b._numerator == 0)
                throw new DivideByZeroException("В следствие операции деления с нулевым числителем у делителя, приводит к появлению дроби с нулевым знаменателем, а на нуль делить нельзя!");

            return new(a._numerator * b._denominator, a._denominator * b._numerator);
        }
        #endregion

        #region operations Division_with_remainder
        public static double operator %(Fraction a, double b) => Round(a._numerator / a._denominator % b, 2);

        public static double operator %(double a, Fraction b) => Round(b._numerator / b._denominator % a, 2);

        public static double operator %(Fraction a, Fraction b)
        {
            if (b._numerator == 0)
                throw new DivideByZeroException("В следствие операции деления с нулевым числителем у делителя, приводит к появлению дроби с нулевым знаменателем, а на нуль делить нельзя!");

            return Round(a._numerator / a._denominator % b._numerator / b._denominator, 2);
        }
        #endregion

        #region operations Comparison
        public static bool operator <(Fraction a, double b) => a._numerator / a._denominator < b ? true : false;
        public static bool operator >(Fraction a, double b) => a._numerator / a._denominator > b ? true : false;
        public static bool operator <(double a, Fraction b) => a < b._numerator / b._denominator ? true : false;
        public static bool operator >(double a, Fraction b) => a > b._numerator / b._denominator ? true : false;
        public static bool operator <(Fraction a, Fraction b) => a._numerator / a._denominator < b._numerator / b._denominator ? true : false;
        public static bool operator >(Fraction a, Fraction b) => a._numerator / a._denominator > b._numerator / b._denominator ? true : false;

        public static bool operator <=(Fraction a, double b) => a._numerator / a._denominator <= b ? true : false;
        public static bool operator >=(Fraction a, double b) => a._numerator / a._denominator >= b ? true : false;
        public static bool operator <=(double a, Fraction b) => a <= b._numerator / b._denominator ? true : false;
        public static bool operator >=(double a, Fraction b) => a >= b._numerator / b._denominator ? true : false;
        public static bool operator <=(Fraction a, Fraction b) => a._numerator / a._denominator <= b._numerator / b._denominator ? true : false;
        public static bool operator >=(Fraction a, Fraction b) => a._numerator / a._denominator >= b._numerator / b._denominator ? true : false;
        #endregion

        #region operations Equality

        

        #endregion
    }
}
