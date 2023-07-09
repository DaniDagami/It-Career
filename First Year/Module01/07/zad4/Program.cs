namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string plant = Console.ReadLine();
            if (plant == "banana" || plant == "apple"
                || plant == "kiwi" || plant == "cherry" || plant == "cherry"
                || plant == "lemon" || plant == "grapes")
                Console.WriteLine("fruit");
            else if (plant == "tomato" || plant == "cucumber"
                || plant == "pepper" || plant == "carot")
                Console.WriteLine("vegetable");
            else Console.WriteLine("unknown");
        }
    }
}