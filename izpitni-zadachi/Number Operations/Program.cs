int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
char op = char.Parse(Console.ReadLine());
if (op == '+')
{
    if ((n1 + n2) % 2 == 0) Console.WriteLine($"{n1} {op} {n2} = {n1 + n2} - even");
    else Console.WriteLine($"{n1} {op} {n2} = {n1 + n2} - odd");
}
else if (op == '-')
{
    if ((n1 - n2) % 2 == 0) Console.WriteLine($"{n1} {op} {n2} = {n1 - n2} - even");
    else Console.WriteLine($"{n1} {op} {n2} = {n1 - n2} - odd");
}
else if (op == '*')
{
    if (n1 * n2 % 2 == 0) Console.WriteLine($"{n1} {op} {n2} = {n1 * n2} - even");
    else Console.WriteLine($"{n1} {op} {n2} = {n1 * n2} - odd");
}
else if (op == '/')
{   if (n2 != 0)
    {
        double del = n1 / n2;
        Console.WriteLine($"{n1} {op} {n2} = {del:f2}");
    }
    else Console.WriteLine($"Cannot divide {n1} by zero");
}
else if (op == '%')
{
    if (n2 != 0)
    {
        Console.WriteLine($"{n1} {op} {n2} = {n1%n2}");
    }
    else Console.WriteLine($"Cannot divide {n1} by zero");
}