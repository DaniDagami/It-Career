namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int comingHour = int.Parse(Console.ReadLine());
            int comingMinutes = int.Parse(Console.ReadLine());
            examHour = examHour * 60;
            comingHour = comingHour * 60;
            int exam = examHour + examMinutes;
            int coming = comingHour + comingMinutes;
            if (exam < coming)
            {
                Console.WriteLine("Late");
                if (coming - exam < 60) Console.WriteLine($"{coming - exam} minutes after the start");
                else Console.WriteLine($"{(coming - exam) / 60:d}:{(coming - exam) % 60:d2} hours after the start");
            }
            else if (exam - coming <= 30)
            {
                Console.WriteLine("On time");
                if (exam - coming > 0) Console.WriteLine($"{exam - coming} minutes before the start");
                else { }
            }
            else if (exam - coming > 30)
            {
                Console.WriteLine("Early");
                if (exam - coming < 60) Console.WriteLine($"{exam - coming} minutes before the start");
                else Console.WriteLine($"{(exam - coming) / 60:d}:{(exam - coming) % 60:d2} hours before the start");
            }
        }
    }
}