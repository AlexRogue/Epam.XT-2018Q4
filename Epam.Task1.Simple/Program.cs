using System;


namespace Epam.Task1.Simple
{
    class Program
    {
        public static void Main()
        {
            {
                Console.WriteLine("This is a \"Prime number chacking machine\". Enter your number and then press button Enter");
                ResultParser resultParser = new ResultParser();
                var number = resultParser.ParseResult();
                NumberChecker ob = new NumberChecker(number);
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
}
