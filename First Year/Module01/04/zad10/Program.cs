namespace zad10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double euro = (bitcoin * 1168 + yuan * 0.15 * 1.76) / 1.95;
            double result = euro - euro * (commision/100);
            Console.WriteLine($"{result:f2}");
        }
    }
}