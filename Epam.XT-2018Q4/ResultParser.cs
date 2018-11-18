using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.XT_2018Q4
{
    class ResultParser
    {
        int number;
        bool evenNumberChecker;
        bool positiveChecker;

        public int ParseResult()
        {
            do
            {
                Int32.TryParse(Console.ReadLine(), out number);
                evenNumberChecker = (number % 2 == 0);
                positiveChecker = number < 0;
                if (evenNumberChecker)
                {
                    Console.WriteLine("Number is not odd. Enter number again");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Number is negative. Enter number again");
                }
            }
            while (evenNumberChecker | positiveChecker);
            return number;
        }
    }
}
