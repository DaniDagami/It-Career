while (true)
{
    try
    {
        Console.Write("Enter even number: ");
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine($"Even number entered: {n}");
            break;
        }
        else Console.WriteLine("Number is not even"); 

    }
    catch
    {
        Console.WriteLine("Invalid number");
    }
}
