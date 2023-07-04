namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimeter = Math.PI * r * 2;
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}