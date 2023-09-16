namespace _2 {
    class Program {
        static void Main(string[] args) {
            Family family = new Family("Smiths");

            int n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= n; i++) {
                List<string> arg = Console.ReadLine().Split(' ').Where(x=> x!="").ToList();
                family.People.Add(new Person(int.Parse(args[1]), args[0]));
            }

            family.Print();
        }
    }
}