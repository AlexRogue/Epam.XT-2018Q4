using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a sequence generator. Enter your number and then press button Enter");
            int number = new ResultParser().ParseResult();
            List<int> collection = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                collection.Add(i);
            }
            collection.ForEach(x =>
            {
                if (x != number)
                {
                    Console.Write($"{x}, ");
                }
                else
                {
                    Console.Write($"{x} ");
                }
            });
        }
    }
}
