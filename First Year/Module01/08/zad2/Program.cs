namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double hour = double.Parse(Console.ReadLine());
            double pipe1_Hour = pipe1 * hour;
            double pipe2_Hour = pipe2 * hour;
            double total = (pipe1 + pipe2) * hour;

            if (total < volume)
            {
                double fill = (total / volume) * 100;
                double pipe1_Fill = (pipe1_Hour / total) * 100;
                double pipe2_Fill = (pipe2_Hour / total) * 100;
                Console.WriteLine($"The pool is {Math.Truncate(fill)}% full. Pipe 1: {Math.Truncate(pipe1_Fill)}%. Pipe 2: {Math.Truncate(pipe2_Fill)}%");
            }
            else if (total > volume)
            {
                Console.WriteLine($"For {hour} hours the pool overflows with {total - volume:f1} liters. ");
            }

        }
    }
}