namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double a, b;

            if (shape == "square")
            {
                a = double.Parse(Console.ReadLine());
                Console.WriteLine(a * a);
            }
            if (shape == "rectangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            if (shape == "circle")
            {
                a = double.Parse(Console.ReadLine());
                Console.WriteLine(a * a * Math.PI);
            }
            if (shape == "triangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b / 2);
            }
        }
    }
}