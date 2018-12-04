using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1._3.AnotherTriangle
{
   public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter number to print pyramid");
            int n = int.Parse(Console.ReadLine());
            for (int triangle = 0; triangle <= n; triangle++)
            {
                for (int j = 0; j <= n + triangle; j++)
                {
                    if (j >= n - triangle)
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


