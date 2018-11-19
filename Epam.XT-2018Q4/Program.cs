using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.XT_2018Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a star generator. Enter your number and then press button Enter");
            ResultParser resultParser = new ResultParser();
            int number = resultParser.ParseResult();
            StarProducer starProducer = new StarProducer(number);
            starProducer.GenerateStarField();            
        }
    }
}

