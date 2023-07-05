namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            if (word1.ToLower() == word2.ToLower())
            {
                Console.WriteLine("yes");
            }
            else Console.WriteLine("no");
        }
    }
}