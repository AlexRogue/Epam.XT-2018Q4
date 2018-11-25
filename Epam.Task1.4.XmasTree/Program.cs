using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1._4.XmasTree
{
    class Program
    {
        static void Main()
        {
            int number;
            bool checkNumber;
            Console.WriteLine("Enter the number of triangles");
            do
            {
                checkNumber = !int.TryParse(Console.ReadLine(), out number);
                if (checkNumber)
                {
                    Console.WriteLine("You entered a wrong value. Try again");
                }
                else if (number < 0)
                {
                    Console.WriteLine("You entered a value lower than zero. Try again");
                }

            } while (checkNumber || number < 0);


            for (int triangle = 0; triangle <= number; triangle++)
            {
                for (int i = 0; i <= triangle; i++)
                {
                    for (int j = 0; j <= number + i; j++)
                    {
                        if (j >= number - i)
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
}
