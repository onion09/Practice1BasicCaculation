using System.Security.Cryptography.X509Certificates;

namespace Practice1BasicCaculation
{
    public class Program
    {
        static void Main(string[] args)
        {
            int value1 = 1; int value2 = 2; int option = 4;
            int result = BasicCaculation.Caculation(value1,value2, option);
            Console.WriteLine(result);
        }

    }
    public static class BasicCaculation
    {
        public static int  Caculation(int value1, int value2, int option) 
        {
            if (option > 3 || option<1)
            {
                throw new ArgumentOutOfRangeException(nameof(option));
            }
            switch(option)
            {
                case 1:
                    return Sum(value1, value2);
                    break;
                case 2:
                    return Sub(value1, value2);
                    break;
                case 3:
                    return Multi(value1, value2);
                    break;
                default: 
                    return 0;
            }
        }
        private static int Sum(int value1, int value2)
        {
            return value1 + value2;
        }
        private static int Sub(int value1, int value2)
        {
            return value1 - value2;
        }
        private static int Multi(int value1, int value2)
        {
            return value1 * value2;
        }
    }
}