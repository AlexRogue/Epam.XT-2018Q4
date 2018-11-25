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
            int numberoflayer = int.Parse(Console.ReadLine());
            Console.WriteLine("Print paramid");
            for (int i = 1; i <= numberoflayer; i++) 
            {
                for (int a = 1; a <= (numberoflayer - i); a++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int j = (i - 1); j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

