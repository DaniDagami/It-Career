namespace _1 {
    internal class Program {
        static void Main(string[] args) {
            List<RationalNumber> numbers = new List<RationalNumber>();
            for (int i = 0; i < 4; i++) {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                numbers.Add(new RationalNumber(a, b));
            }
            foreach (var item in numbers) {
            foreach (var item in numbers) {
                Console.WriteLine(item);
            }
        }
    }
}