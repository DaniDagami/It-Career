using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1 {
    public class RationalNumber {
        private double numerator;
        private double denominator;

        public RationalNumber(double numerator, double denominator) {
            Numerator = numerator;
            Denominator = denominator;
        }

        public double Numerator {
            get { return numerator; }
            set { numerator = value; }
        }
        public double Denominator {
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
