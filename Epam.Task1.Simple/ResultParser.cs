using System;


namespace Epam.Task1.Simple
{
    public class ResultParser
    {
        int number;
        bool positiveChecker;

        public int ParseResult()
        {
            do
            {
                Int32.TryParse(Console.ReadLine(), out number);
                positiveChecker = number <= 0;
                if (number <= 0)
                {
                    Console.WriteLine("You entered not appropriate number. Enter number again. Try to use number bigger then 0 and it should be an integer");
                }
            }
            while (positiveChecker);
            return number;
        }
    }
}
