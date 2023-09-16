namespace _3 {
    public class RationalNumber {
        private int numerator;
        private int denominator;

        public RationalNumber(int numerator, int denominator) {
            Numerator = numerator;
            Denominator = denominator;
        }
        public int Numerator {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator {
            get { return denominator; }
            set {
                if (value == 0) {
                    throw new ArgumentException();
                }
                denominator = value;
            }
        }
        public override string? ToString() {
            return $"{this.Numerator}/{this.Denominator}";
        }
    }
}
