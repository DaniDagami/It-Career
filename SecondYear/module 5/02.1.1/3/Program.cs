namespace _3 {
    class Program {
        static void Main(string[] args) {
            Family family= new Family();

            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                List<string> arg = Console.ReadLine().Split(' ').Where(x => x != "").ToList();
                family.People.Add(new Person(arg[0], int.Parse(arg[1]));
            }

            family.PrintAbove30();

        }
    }
}