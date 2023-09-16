using System.Globalization;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime datetime = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
            datetime = datetime.AddDays(999);
            Console.WriteLine(datetime.ToString("dd-MM-yyyy"));
        }
    }
}