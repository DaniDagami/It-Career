namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double area = Math.Abs(x1-x2)*Math.Abs(y2 - y1);
            double perimeter = (Math.Abs(x1-x2)+Math.Abs(y2 - y1))*2;
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}