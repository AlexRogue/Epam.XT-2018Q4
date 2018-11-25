using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEpam.Task1._10._2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] d = new int[,] { { 1, 2 } , { 1, 4 },{ 1, 7 },{ 6, 8 }};
            int sum = 0;
            for (int i = 0; i < d.Length; i++)
            {
                for (int j = 0; j < d.GetUpperBound(i); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += d[i, j];
                    }
                }
            }
            Console.Write(sum);
        }
    }
}
