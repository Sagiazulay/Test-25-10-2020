using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_25102020
{
    class Rational
    {
        public int A { get; set; }
        public int B { get; set; }

        public Rational(int a, int b)
        {
            if (a > 0)
                A = a;
            else
                A = 0;

            if (b > 0)
                B = b;
            else
                B = 0;
        }


        public bool GreaterThan(int c, int d)
        {
            if ((A * d) > (B * c))
                return true;

            return false;
        }

        public override bool Equals(object obj)
        {
            return obj is Rational rational &&
                   A == rational.A &&
                   B == rational.B;
        }
        public static Rational operator +(Rational c, Rational d)
        {
            Rational result = new Rational(((c.A * d.B) + (c.B * d.A)), (c.B * d.B));
            return result;
        }
        public static Rational operator -(Rational c, Rational d)
        {
            Rational result = new Rational(((c.A * d.B) - (c.B * d.A)), (c.B * d.B));
            return result;
        }
        public static Rational operator *(Rational c, Rational d)
        {
            Rational result = new Rational((c.A * d.A), (c.B * d.B));
            return result;
        }
        public int GetNumerator()
        {
            return A;
        }
        public int GetDenomerator()
        {
            return B;
        }

        public override string ToString()
        {
            return $"({A} / {B})";
        }
    }
}
