using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{

    public struct Fraction
    {
        private long nomerator;

        private long denominator;

        public Fraction(long nomerator, long denomerator) : this()
        {
            this.Nomerator = nomerator;
            this.Denomerator = denomerator;
        }

        public long Nomerator { get; set; }

        public long Denomerator
        {
            get
            {
                return this.denominator;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("The denominator cannot be zero!!");
                }
                this.denominator = value;
            }
        }

        private static long GreatestCommonFraction(long a, long b)
        {
            while (b > 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private static long LeastCommonFraction(long a, long b)
        {
            long result = (a * b) / GreatestCommonFraction(a, b);
            return result;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            long lcf = LeastCommonFraction(a.Denomerator, b.Denomerator);
            long denominator = lcf;
            long numerator = (a.Nomerator * lcf / a.Denomerator) + (b.Nomerator * lcf / b.Denomerator);
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            long lcf = LeastCommonFraction(a.Denomerator, b.Denomerator);
            long denominator = lcf;
            long numerator = (a.Nomerator * lcf / a.Denomerator) - (b.Nomerator * lcf / b.Denomerator);
            return new Fraction(numerator, denominator);
        }

        public override string ToString()
        {
            return string.Format("{0}", (decimal)this.Nomerator / this.Denomerator);
        }
    }
}
