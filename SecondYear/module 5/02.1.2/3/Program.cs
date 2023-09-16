namespace _3 {
    internal class Program {
        static void Main(string[] args) {
            List<int> list = Console.ReadLine().Split(' ').Where(x => x != "").Select(int.Parse).ToList();
            List<RationalNumber> numbers = new();
            for (int i = 0; i < list.Count; i += 2) {
                numbers.Add(new RationalNumber(list[i], list[i + 1]));
            }
            foreach (var item in numbers) {
                if (numbers.IndexOf(item) != numbers.Count - 1) {
                    Console.Write(item + "; ");
                } else {
                    Console.WriteLine(item);
                }
            }
        }
    }
}