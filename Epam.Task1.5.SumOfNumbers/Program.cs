using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1._5.SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sum = 0;
            int[,] array = new int[3, 3];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-15, 15);
                    if ((i + j) % 2 == 0)
                    {
                        sum += array[i, j];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
