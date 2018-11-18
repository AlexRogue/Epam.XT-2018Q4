using System;


namespace Epam.Task1.Simple
{
    class Program
    {
        public static void Main()
        {
            {
                ResultParser resultParser = new ResultParser();
                var number = resultParser.ParseResult();
                CheckNumber ob = new CheckNumber(number);
                if (ob.IsPrime())
                {
                    Console.WriteLine(number + " is a prime number.");
                }
                else
                {
                    Console.WriteLine(number + " is not a prime number.");
                }
             }
        }
    }

    class CheckNumber
    {
        int number;

        public CheckNumber(int number)
        {
            this.number = number;
        }


        public bool IsPrime()
        {
            for (int i = 2; i < number; i++)
                if ((number % i) == 0) return false;
            return true;
        }
    }
}
