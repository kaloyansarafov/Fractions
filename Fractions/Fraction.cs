using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int n, int d)
        {
            this.Numerator = n;
            this.Denominator = d;
        }

        public Fraction(string drop)
        {
            int[] nums = drop.Split(' ').Select(n => int.Parse(n)).ToArray();
            this.Numerator = nums[0];
            this.Numerator = nums[1];
        }

        public static Fraction Parse(string fraction)
        {
            if (fraction == null)
                Console.WriteLine("Invalid Expression");

            string[] split = fraction.Split('/');
            int len = split.Length;

            if (len == 2)
            {
                int s0 = int.Parse(split[0]);
                int s1 = int.Parse(split[1]);
                return new Fraction(s0, s1);
            }
            else
            {
                Console.WriteLine("Invalid Expression");
                return new Fraction(0, 0);
            }
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int oldB = b;
                b = a % b;
                a = oldB;
            }
            return a;
        }

        public override string ToString()
        {
            if (this.Denominator == 1)
            {
                return this.Numerator.ToString();
            }
            return this.Numerator + "/" + this.Denominator;
        }

        public static Fraction operator +(Fraction fr1, Fraction fr2)
        {
            Fraction result = new Fraction(1, 1);
            result.Denominator = fr1.Denominator * fr2.Denominator;
            result.Numerator = fr1.Numerator * fr2.Denominator + fr2.Numerator * fr1.Denominator;
            int g = GCD(result.Numerator, result.Denominator);
            result.Numerator /= g;
            result.Denominator /= g;
            return result;
        }

        public static Fraction operator -(Fraction fr1, Fraction fr2)
        {
            Fraction result = new Fraction(1, 1);
            result.Denominator = fr1.Denominator * fr2.Denominator;
            result.Numerator = fr1.Numerator * fr2.Denominator - fr2.Numerator * fr1.Denominator;
            int g = GCD(result.Numerator, result.Denominator);
            result.Numerator /= g;
            result.Denominator /= g;
            return result;
        }

        public static Fraction operator *(Fraction fr1, Fraction fr2)
        {
            Fraction result = new Fraction(1, 1);

            result.Denominator = fr1.Denominator * fr2.Denominator;
            result.Numerator = fr1.Numerator * fr2.Numerator;
            int g = GCD(result.Numerator, result.Denominator);

            result.Numerator /= g;
            result.Denominator /= g;

            return result;
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            int r1 = a.Numerator * b.Denominator;
            int r2 = a.Denominator * b.Numerator;

            return new Fraction(r1, r2);
        }

        public static bool operator ==(Fraction fr1, Fraction fr2)
        {
            int res = fr1.Numerator * fr2.Denominator - fr2.Numerator * fr1.Denominator;
            return (res == 0) ? true : false;
        }

        public static bool operator !=(Fraction fr1, Fraction fr2)
        {
            return !(fr1 == fr2);
        }

        public static bool operator <(Fraction fr1, Fraction fr2)
        {
            int res = fr1.Numerator * fr2.Denominator - fr2.Numerator * fr1.Denominator;
            return (res < 0) ? true : false;
        }

        public static bool operator >(Fraction fr1, Fraction fr2)
        {
            int res = fr1.Numerator * fr2.Denominator - fr2.Numerator * fr1.Denominator;
            return (res > 0) ? true : false;
        }

        public static bool operator <=(Fraction fr1, Fraction fr2)
        {
            int res = fr1.Numerator * fr2.Denominator - fr2.Numerator * fr1.Denominator;
            return (res <= 0) ? true : false;
        }

        public static bool operator >=(Fraction fr1, Fraction fr2)
        {
            int res = fr1.Numerator * fr2.Denominator - fr2.Numerator * fr1.Denominator;
            return (res >= 0) ? true : false;
        }
    }
}
