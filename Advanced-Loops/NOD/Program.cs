int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
while (b != 0)
{
    int oldb = b;
    b = a % b;
    a = oldb;
}
Console.WriteLine(a);