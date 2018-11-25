using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1._9.NonNegativeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] d = {1, 3, 4, 4, -2, -4, -6};
            int sum = 0;
            foreach (int i in d)
            {
                if (i > 0)
                {
                    sum += i;
                }
            }
            Console.Write(sum);
        }
    }
}
