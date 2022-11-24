int n = int.Parse(Console.ReadLine());
int sum = 0;
while (n > 1)
{
    sum = sum + (n % 10);
    n = n / 10;
}
Console.WriteLine(sum);