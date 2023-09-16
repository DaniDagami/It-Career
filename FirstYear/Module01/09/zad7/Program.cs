namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0, rightSum = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum+=num;
            }
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                rightSum += num;
            }
            if (leftSum == rightSum)
                Console.WriteLine($"Yes sum = {leftSum}");
            else
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
        }
    }
}