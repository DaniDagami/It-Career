namespace _5 {
    public class EvenNumber {
        private int num;

        public EvenNumber(int num) {
            Num = num;
        }

        public int Num {
            get { return num; }
            set {
                if (value % 2 == 1)
                    throw new ArgumentException();
                num = value;
            }
        }

    }
}
