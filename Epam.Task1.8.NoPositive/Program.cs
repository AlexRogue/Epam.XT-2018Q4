using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1._8.NoPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,,] array = new int[3, 3, 3];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int a = 0; a < array.GetLength(2); a++)
                    {
                        array[i, j, a] = random.Next(-15, 15);
                        Console.Write(array[i, j, a] + " ");
                    }
                }
            }

            Console.WriteLine($"3D Array before operation: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int a = 0; a < array.GetLength(2); a++)
                    {
                        if (array[i, j, a] > 0)
                        {
                            array[i, j, a] = 0;
                            Console.Write(array[i, j, a] + " ");
                        }
                        else
                        {
                            Console.Write(array[i, j, a] + " ");
                        }
                    }
                }
            }
        }
    }
}
