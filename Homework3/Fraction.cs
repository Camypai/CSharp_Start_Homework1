using System;

namespace Homework3
{
    public class Fraction
    {
        private int _denominator;

        private Fraction()
        {
        }

        private Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            _denominator = denominator;
        }

        public int Numerator { get; set; }

        public int Denominator
        {
            get => _denominator;
            private set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0.");
                }

                _denominator = value;
            }
        }

        public double Decimal => (double) Numerator / (double) _denominator;

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            var fraction = new Fraction
            {
                Numerator = f1.Numerator * f2.Denominator + f1.Denominator * f2.Numerator,
                Denominator = f1.Denominator * f2.Denominator
            };

            return fraction;
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            var fraction = new Fraction
            {
                Numerator = f1.Numerator * f2.Denominator - f1.Denominator * f2.Numerator,
                Denominator = f1.Denominator * f2.Denominator
            };

            return fraction;
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            var fraction = new Fraction
            {
                Numerator = f1.Numerator * f2.Numerator,
                Denominator = f1.Denominator * f2.Denominator
            };

            return fraction;
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            var fraction = new Fraction
            {
                Numerator = f1.Numerator * f2.Denominator,
                Denominator = f1.Denominator * f2.Numerator
            };

            return fraction;
        }

        public override string ToString()
        {
            return $"{Numerator}/{_denominator}";
        }

        public static bool TryParse(string fraction, out Fraction result)
        {
            var tryNumerator = int.TryParse(fraction.Split('/')[0], out var numerator);
            var tryDenominator = int.TryParse(fraction.Split('/')[1], out var denominator);
            if (tryDenominator && tryNumerator)
            {
                result = new Fraction
                {
                    Numerator = numerator,
                    Denominator = denominator
                };
                return true;
            }

            result = null;
            return false;
        }

        public static Fraction Simple(Fraction fraction)
        {
            var n = fraction.Numerator;
            var d = fraction.Denominator;
            var i = 2;
            while (n != 1 && n / i != 1)
            {
                if (n % i == 0 && d % i == 0)
                {
                    n /= i;
                    d /= i;
                    i = 2;
                }
                else
                {
                    i++;
                }
            }

            return new Fraction(n, d);
        }
    }
}