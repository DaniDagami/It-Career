namespace zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            int cinema = row * column;
            if (type == "Premiere") Console.WriteLine($"{cinema * 12:f2} leva");
            if (type == "Normal") Console.WriteLine($"{cinema * 7.5:f2} leva");
            if (type == "Discount") Console.WriteLine($"{cinema * 5:f2} leva");
        }
    }
}