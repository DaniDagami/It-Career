int n = int.Parse(Console.ReadLine());
int br = 1;
for (int i = 2; i <= n; i++)
{
    if (n % i == 0) br++;
}
if (n < 1) Console.WriteLine("Not Prime");
else if (br == 2) Console.WriteLine("Prime");
else Console.WriteLine("Not Prime");