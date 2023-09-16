namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double unit = double.Parse(Console.ReadLine());
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (first == "mm")
                unit /= 1000;
            if (first == "cm")
                unit /= 100;
            if (first == "mi")
                unit /= 0.000621371192;
            if (first == "in")
                unit /= 39.3700787;
            if (first == "km")
                unit /= 0.001;
            if (first == "ft")
                unit /= 3.2808399;
            if (first == "yd")
                unit /= 1.0936133;

            if (second == "mm")
                unit *= 1000;
            if (second == "cm")
                unit *= 100;
            if (second == "mi")
                unit *= 0.000621371192;
            if (second == "in")
                unit *= 39.3700787;
            if (second == "km")
                unit *= 0.001;
            if (second == "ft")
                unit *= 3.2808399;
            if (second == "yd")
                unit *= 1.0936133;

            Console.WriteLine($"{unit} {second}");
        }
    }
}