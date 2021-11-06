using System;
using static System.Math;

namespace Lesson5.Task_1
{
    public readonly partial struct Fraction : IEquatable<Fraction>
    {
        #region operations Sum 
        public static Fraction operator +(in Fraction a, double b) => new(a._numerator * b + b * a._denominator, a._denominator);

        public static Fraction operator +(double a, in Fraction b) => new(b._numerator * a + a * b._denominator, b._denominator);

        public static Fraction operator +(in Fraction a, in Fraction b) => new(a._numerator * b._denominator + b._numerator * a._denominator, a._denominator * b._denominator);

        public static Fraction operator ++(in Fraction a) => new(a._numerator * 1 + 1 * a._denominator, a._denominator);
        #endregion

        #region operations Sub
        public static Fraction operator -(in Fraction a, double b) => new(a._numerator * b - b * a._denominator, a._denominator);

        public static Fraction operator -(double a, in Fraction b) => new(b._numerator * a - a * b._denominator, b._denominator);

        public static Fraction operator -(in Fraction a, in Fraction b) => new(a._numerator * b._denominator - b._numerator * a._denominator, a._denominator * b._denominator);

        public static Fraction operator -(in Fraction a) => new(-a._numerator, a._denominator);

        public static Fraction operator --(in Fraction a) => new(a._numerator * 1 - 1 * a._denominator, a._denominator);
        #endregion

        #region operations Inc
        public static Fraction operator *(in Fraction a, double b) => new(a._numerator * b, a._denominator);

        public static Fraction operator *(double a, in Fraction b) => new(b._numerator * a, b._denominator);

        public static Fraction operator *(in Fraction a, in Fraction b) => new(a._numerator * b._numerator, a._denominator * b._denominator);
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
        public static double operator %(in Fraction a, double b) => Round(a._numerator / a._denominator % b, 2);

        public static double operator %(double a, in Fraction b) => Round(b._numerator / b._denominator % a, 2);

        public static double operator %(in Fraction a, in Fraction b)
        {
            if (b._numerator == 0)
                throw new DivideByZeroException("В следствие операции деления с нулевым числителем у делителя, приводит к появлению дроби с нулевым знаменателем, а на нуль делить нельзя!");

            return Round(a._numerator / a._denominator % b._numerator / b._denominator, 2);
        }
        #endregion

        #region operations Comparison
        public static bool operator <(in Fraction a, double b) => a._numerator / a._denominator < b;
        public static bool operator >(in Fraction a, double b) => a._numerator / a._denominator > b;
        public static bool operator <(double a, in Fraction b) => a < b._numerator / b._denominator;
        public static bool operator >(double a, in Fraction b) => a > b._numerator / b._denominator;
        public static bool operator <(in Fraction a, in Fraction b) => a._numerator / a._denominator < b._numerator / b._denominator;
        public static bool operator >(in Fraction a, in Fraction b) => a._numerator / a._denominator > b._numerator / b._denominator;

        public static bool operator <=(in Fraction a, double b) => a._numerator / a._denominator <= b;
        public static bool operator >=(in Fraction a, double b) => a._numerator / a._denominator >= b;
        public static bool operator <=(double a, in Fraction b) => a <= b._numerator / b._denominator;
        public static bool operator >=(double a, in Fraction b) => a >= b._numerator / b._denominator;
        public static bool operator <=(in Fraction a, in Fraction b) => a._numerator / a._denominator <= b._numerator / b._denominator;
        public static bool operator >=(in Fraction a, in Fraction b) => a._numerator / a._denominator >= b._numerator / b._denominator;
        #endregion

        #region operations Equality
        public override bool Equals(object obj) => obj is Fraction other && Equals(other);
        public override int GetHashCode() => HashCode.Combine(_numerator, _denominator);
        public bool Equals(Fraction other) => _numerator.Equals(other._numerator) && _denominator.Equals(other._denominator);

        public static bool operator ==(in Fraction a, double b) => (a._numerator / a._denominator).Equals(b);
        public static bool operator !=(in Fraction a, double b) => !(a._numerator / a._denominator).Equals(b);
        public static bool operator ==(double a, in Fraction b) => a.Equals(b._numerator / b._denominator);
        public static bool operator !=(double a, in Fraction b) => !a.Equals(b._numerator / b._denominator);
        public static bool operator ==(in Fraction a, in Fraction b) => (a._numerator / a._denominator).Equals(b._numerator / b._denominator);
        public static bool operator !=(in Fraction a, in Fraction b) => !(a._numerator / a._denominator).Equals(b._numerator / b._denominator);
        #endregion

        #region operations Explicit/Implicit
        public static explicit operator Fraction(float a)
        {
            var f = (float)Round(a, 1);
            return new(f * 10, 10);
        } 
        public static implicit operator float(in Fraction a) => (float)(a._numerator / a._denominator);

        public static explicit operator Fraction(int a) => new(a, 1);
        public static implicit operator int(in Fraction a) => (int)(a._numerator / a._denominator);
        #endregion
    }
}
