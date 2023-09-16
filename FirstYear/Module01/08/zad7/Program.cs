namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());

            if (@operator == '+')
            {
                if ((number1 + number2) % 2 == 0)
                    Console.WriteLine($"{number1} {@operator} {number2} = {number1 + number2} - even");
                else
                    Console.WriteLine($"{number1} {@operator} {number2} = {number1 + number2} - odd");
            }
            else if (@operator == '-')
            {
                if ((number1 - number2) % 2 == 0)
                    Console.WriteLine($"{number1} {@operator} {number2} = {number1 - number2} - even");
                else
                    Console.WriteLine($"{number1} {@operator} {number2} = {number1 - number2} - odd");
            }
            else if (@operator == '*')
            {
                if (number1 * number2 % 2 == 0)
                    Console.WriteLine($"{number1} {@operator} {number2} = {number1 * number2} - even");
                else
                    Console.WriteLine($"{number1} {@operator} {number2} = {number1 * number2} - odd");
            }
            else if (@operator == '/')
            {
                if (number2 != 0)
                {
                    double del = number1 / number2;
                    Console.WriteLine($"{number1} {@operator} {number2} = {del:f2}");
                }
                else
                    Console.WriteLine($"Cannot divide {number1} by zero");
            }
            else if (@operator == '%')
            {
                if (number2 != 0)
                {
                    Console.WriteLine($"{number1} {@operator} {number2} = {number1 % number2}");
                }
                else
                    Console.WriteLine($"Cannot divide {number1} by zero");
            }
        }
    }
}