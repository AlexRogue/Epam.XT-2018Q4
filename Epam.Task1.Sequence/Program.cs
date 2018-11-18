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
            Console.WriteLine("Enter your number. Press button Enter");
            int number = new ResultParser().ParseResult();
            List<int> collection = new List<int>();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 1; i <= number; i++)
            {
                collection.Add(i);
            }
            collection.ForEach(x =>
            {
                if (x != number)
                {
                    stringBuilder.Append(x).Append(", ");
                }
                else
                {
                    stringBuilder.Append(x).Append(" ");
                }
            });
            Console.Write(stringBuilder);
        }
    }
}
