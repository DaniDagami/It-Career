namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            h -= 1;

            double workspaces = Math.Floor(w / 1.2) * Math.Floor(h/0.7) - 3;
            Console.WriteLine(workspaces);
        }
    }
}