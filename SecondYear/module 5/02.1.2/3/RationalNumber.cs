﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3 {
    class RationalNumber {
        private int numerator;
        private int denumerator;
        public RationalNumber(int numerator, int denumerator) {
            if (denumerator < 0) {
                numerator *= -1;
                denumerator *= -1;
            }
            Numerator = numerator;
            Denumerator = denumerator;
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

        public int BiggestDivider() {
            int nod = 1;
            int r = 0;
            int a = Numerator;
            int b = Denumerator;

            while (b != 0) {
                r = a % b;
                a = b;
                b = r;
            }

            nod = a;
            return nod;
        }
    }
}