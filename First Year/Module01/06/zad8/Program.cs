namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a < 0 || a > 100) Console.WriteLine("invalid number");
            else if (a == 100) Console.WriteLine("one hundred");
            else
            {
                int des = a / 10;
                int ed = a % 10;
                string ans = "", ans1 = "", ans2 = "";
                if (ed == 0 && des == 0) Console.WriteLine("zero");
                else
                {
                    if (ed == 1) ans2 = "one";
                    else if (ed == 2) ans2 = "two";
                    else if (ed == 3) ans2 = "three";
                    else if (ed == 4) ans2 = "four";
                    else if (ed == 5) ans2 = "five";
                    else if (ed == 6) ans2 = "six";
                    else if (ed == 7) ans2 = "seven";
                    else if (ed == 8) ans2 = "eight";
                    else if (ed == 9) ans2 = "nine";
                    if (des == 2) ans1 = "twenty";
                    else if (des == 3) ans1 = "thirty";
                    else if (des == 4) ans1 = "forty";
                    else if (des == 5) ans1 = "fifty";
                    else if (des == 6) ans1 = "sixty";
                    else if (des == 7) ans1 = "seventy";
                    else if (des == 8) ans1 = "eighty";
                    else if (des == 9) ans1 = "ninety";
                    if (ans2.Equals("")) ans = ans1;
                    else if (ans1.Equals("")) ans = ans2;
                    else ans = ans1 + " " + ans2;
                    if (des == 1)
                    {
                        if (ed == 0) ans = "ten";
                        else if (ed == 1) ans = "eleven";
                        else if (ed == 2) ans = "twelve";
                        else if (ed == 3) ans = "thirteen";
                        else if (ed == 5) ans = "fifteen";
                        else ans = ans2 + "teen";
                    }
                    Console.WriteLine(ans);
                }
            }
        }