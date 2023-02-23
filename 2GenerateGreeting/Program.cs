using System.Globalization;

namespace _2GenerateGreeting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input your name: ");
            //string input = Console.ReadLine();
            //string result = Greeting(input);
            //Console.WriteLine(result);

            SumofDigits(-12);

        }
        //Practice2 Develop a program/method to generate the greeting (Console Application)
        static string Greeting(string name)
        {
            DateTime time= DateTime.Now;
            string timeofDay = time.ToString("tt", CultureInfo.InvariantCulture);
            string greeting=string.Empty;
            switch (timeofDay)
            {
                case "AM":
                    greeting = "Good morning!";
                    break;
                case "PM":
                    greeting = "Good Afternoon";
                    break;
            }
            string result = $"Hello {name}, {greeting}";
            return result ;
        }
        //Practice3: Develop a program/method to print sum of the digits of given number.
        static void SumofDigits(int input)
        {
            int result = Sum(input);
            Console.WriteLine(result);
        }
        private static int Sum(int input)
        {
            if (input / 10 == 0) return Math.Abs(input);
            return Math.Abs(input % 10) + Math.Abs(Sum(input / 10));
        }
    }
}