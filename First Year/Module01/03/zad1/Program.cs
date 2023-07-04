namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            double area = a * a;
            Console.WriteLine("Square = " + area);
        }
    }
}