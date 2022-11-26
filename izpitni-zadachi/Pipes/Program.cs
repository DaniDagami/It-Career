int v = int.Parse(Console.ReadLine());
int p1 = int.Parse(Console.ReadLine());
int p2 = int.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());
double hp1 = p1 * h;
double hp2 = p2 * h;
double obshto = (p1 + p2) * h;
if (obshto <= v)
{
    
    double x = (obshto / v) * 100;
    double y = (hp1 / obshto) * 100;
    double z = (hp2 / obshto) * 100;
    Console.WriteLine($"The pool is {Math.Truncate(x)}% full. Pipe 1: {Math.Truncate(y)}%. Pipe 2: {Math.Truncate(z)}%");
}
else if (obshto > v)
{
    Console.WriteLine($"For {h} hours the pool overflows with {obshto-v:f1} liters. ");
}
