namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string city = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            if (type == "coffee")
            {
                if (city == "Sofia") Console.WriteLine(count * 0.5);
                if (city == "Plovdiv") Console.WriteLine(count * 0.4);
                if (city == "Varna") Console.WriteLine(count * 0.45);
            }
            if (type == "water")
            {
                if (city == "Sofia") Console.WriteLine(count * 0.8);
                if (city == "Plovdiv") Console.WriteLine(count * 0.7);
                if (city == "Varna") Console.WriteLine(count * 0.7);
            }
            if (type == "beer")
            {
                if (city == "Sofia") Console.WriteLine(count * 1.2);
                if (city == "Plovdiv") Console.WriteLine(count * 1.15);
                if (city == "Varna") Console.WriteLine(count * 1.1);
            }
            if (type == "sweets")
            {
                if (city == "Sofia") Console.WriteLine(count * 1.45);
                if (city == "Plovdiv") Console.WriteLine(count * 1.30);
                if (city == "Varna") Console.WriteLine(count * 1.35);
            }
            if (type == "peanuts")
            {
                if (city == "Sofia") Console.WriteLine(count * 1.6);
                if (city == "Plovdiv") Console.WriteLine(count * 1.5);
                if (city == "Varna") Console.WriteLine(count * 1.55);
            }
        }
    }
}