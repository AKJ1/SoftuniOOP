using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_4
{
    class FractionCalculator
    {
        public static void TestFractions()
        {
            Fraction one = new Fraction(22,7);
            Fraction two = new Fraction(40, 4);
            Fraction f = one + two;
            Console.WriteLine(f);
        }
    }

    struct Fraction
    {
        public long Numerator;
        public long Denominator;

        public Fraction(long numerator, long denominator)
        {
            try
            {
                this.Numerator = numerator;
                this.Denominator = denominator;
                if (denominator <= 0)
                {
                    throw new ArgumentNullException("denominator less or equal to zero!");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Invalid input");
                throw e;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}\n_____\n{1}", this.Numerator.ToString(), this.Denominator.ToString());
        }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            long denom = first.Denominator * second.Denominator;
            long num = (first.Numerator*second.Denominator) + (second.Numerator*first.Denominator);
            return new Fraction(num, denom);
        }
        public static Fraction operator -(Fraction first, Fraction second)
        {
            long denom = first.Denominator * second.Denominator;
            long num = (first.Numerator * second.Denominator) - (second.Numerator * first.Denominator);
            return new Fraction(num, denom);
        }
    }
    
}
