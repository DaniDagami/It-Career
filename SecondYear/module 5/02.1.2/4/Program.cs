namespace _4 {
    internal class Program {
        static void Main(string[] args) {
            List<RationalNumber> rationalNums = new();

            int[] arguments = Console.ReadLine().Split(' ').Where(x => x != "").Select(int.Parse).ToArray();
            for (int i = 0; i < arguments.Length; i += 2) {
                try {
                    rationalNums.Add(new RationalNumber(arguments[i], arguments[i + 1]));
                } catch (DivideByZeroException dbze) {
                    Console.WriteLine(dbze);
                }
            }

            foreach (var num in rationalNums) {
                num.Print();
                if (rationalNums.IndexOf(num) != rationalNums.Count - 1) {
                    Console.Write("; ");
                }
            }
        }
    }
}