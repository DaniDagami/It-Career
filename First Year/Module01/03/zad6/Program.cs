namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double degrees = Math.Round(radians/Math.PI)*180;
            Console.WriteLine(degrees);
        }
    }
}