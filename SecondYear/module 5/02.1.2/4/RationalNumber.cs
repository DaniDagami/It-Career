using System;

namespace _4 {
    class RationalNumber : IComparable {
        private int numerator;
        private int denumerator;
        public RationalNumber(int numerator, int denumerator) {
            if (denumerator < 0) {
                numerator *= -1;
                denumerator *= -1;
            }
            int nod = BiggestDivider(numerator,denumerator);

            Numerator = numerator/nod;
            Denumerator = denumerator/nod;
        }

        public int Numerator { get; set; }
        public int Denumerator {
            get => denumerator;
            set {
                if (value == 0)
                    throw new DivideByZeroException("Cannot divide by zero!");
                denumerator = value;
            }
        }

        public void Print() {
            Console.Write($"{Numerator}/{Denumerator}");
        }

        public int BiggestDivider(int numerator, int denumerator) {
            int nod = 1;
            int r = 0;
            int a = numerator;
            int b = denumerator;

            while (b != 0) {
                r = a % b;
                a = b;
                b = r;
            }

            nod = a;
            return nod;
        }

        public int CompareTo(object? obj) {
            RationalNumber x = (RationalNumber) obj;
            if (Numerator * x.Denumerator < Denumerator * x.Numerator)
                return -1;
            if (Numerator * x.Denumerator == Denumerator * x.Numerator)
                return 0;
            return 1;
        }
    }
}