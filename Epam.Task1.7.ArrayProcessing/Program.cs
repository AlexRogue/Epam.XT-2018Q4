using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1._7.ArrayProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            char min;
            char max;
            do
            {
                Console.WriteLine("Enter min number");
                char.TryParse(Console.ReadLine(), out min);  
                if (!char.IsNumber(min))
                {
                    Console.WriteLine("Exceptions");
                    break;
                }
                array[0] = min;
            } while (!char.IsNumber(min));

            do
            {
                Console.WriteLine("Enter max number");
                char.TryParse(Console.ReadLine(), out max);
                if (!char.IsNumber(max))
                {
                    Console.WriteLine("Exceptions");
                    break;
                }
                array[1] = min;
            } while (!char.IsNumber(max));

            Random random = new Random();
            for (int i = 2; i < array.Length - 2; i++)
            {
                array[i] = random.Next(min, max);
            }


            int temp = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                for (int j = 1; j <= array.Length; i++)
                {
                    if (array[j] > array[i])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            foreach (var i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
