namespace _5 {
    internal class Program {
        static void Main(string[] args) {
            List<EvenNumber> numbers = Console.ReadLine()
                .Split(' ')
                .Where(x => x != "")
                .Where(x => int.Parse(x) % 2 ==0)
                .Select(x => new EvenNumber(int.Parse(x)))
                .ToList();
            Console.WriteLine(string.Join(", " , numbers.Select(x => x.Num).ToList()));
        }
    }
}