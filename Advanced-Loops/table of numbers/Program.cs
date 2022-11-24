int n = int.Parse(Console.ReadLine());
for (int row = 0; row < n; row++)
{
    for (int col = 0; col < n; col++)
    {
        int num = row + col+1;
        if (num > n)
        {
            num = 2 * n - num;
        }
        Console.Write(num + " ");
    }
    Console.WriteLine();
}
