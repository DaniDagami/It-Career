int n = int.Parse(Console.ReadLine());
int f0 = 1;
int f1 = 1;
for (int i = 1; i <= n - 1; i++)
{
    int f = f0 + f1;
    f0 = f1;
    f1 = f;
}
Console.WriteLine(f1);