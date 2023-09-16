namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            if (age<16)
            {
                if (gender == "m") Console.WriteLine("Master");
                else if (gender == "f") Console.WriteLine("Miss");
            }
            else
            {
                if (gender == "m") Console.WriteLine("Mr. ");
                else if (gender == "f") Console.WriteLine("Ms. ");
            }
        }
    }
}