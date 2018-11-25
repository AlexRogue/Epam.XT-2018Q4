using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1._3.AnotherTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to print pyramid");
            int N = int.Parse(Console.ReadLine());
            for (int triangle = 0; triangle <= N; triangle++)
            {
                for (int j = 0; j <= N + triangle; j++)
                {
                    if (j >= N - triangle)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
         }
     }
}


