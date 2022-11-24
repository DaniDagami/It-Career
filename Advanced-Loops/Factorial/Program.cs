int n = int.Parse(Console.ReadLine());
int num = 1;
while (n > 1) 
{
    num = num * n;
    n--;
}
Console.WriteLine(num);