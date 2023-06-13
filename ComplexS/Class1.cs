using System;
using System.Diagnostics.CodeAnalysis;

namespace ComplexS

{
    public struct Complex : IEquatable<Complex>
    {
        public double Re { get; }
        public double Im { get; }
        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }
        public double Abs => Math.Sqrt(Re * Re + Im * Im);
        public override string ToString()
        {
            if (Im == 0)
                return Re.ToString();
            if (Re == 0)
                return $"{Im}i";
            if (Im < 0)
                return $"{Re} - {-Im}i";
            return $"{Re} + {Im}i";
        }
        public override bool Equals(object? obj)
        {
            return obj is Complex complex && Equals(complex);
        }
        public bool Equals([AllowNull] Complex other)
        {
            return Re.Equals(other.Re) && Im.Equals(other.Im);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Re, Im);
        }
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Re + b.Re, a.Im + b.Im);
        }
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Re - b.Re, a.Im - b.Im);
        }
        public static Complex operator *(Complex a, Complex b)
        {
            double re = a.Re * b.Re - a.Im * b.Im;
            double im = a.Re * b.Im + a.Im * b.Re;
            return new Complex(re, im);
        }
        public static Complex operator /(Complex a, Complex b)
        {
            double denominator = b.Re * b.Re + b.Im * b.Im;
            if (denominator == 0)
                throw new DivideByZeroException("Деление на ноль недопустимо.");

            double re = (a.Re * b.Re + a.Im * b.Im) / denominator;
            double im = (a.Im * b.Re - a.Re * b.Im) / denominator;
            return new Complex(re, im);
        }
    }
}