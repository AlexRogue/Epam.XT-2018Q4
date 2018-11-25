using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1._6.FontAdjustment
{
    class Program
    {
        static void Main()
        {
            
            int style = 0;

            do
            {
                Console.WriteLine("Параметры надписи: {0}", (Styles)style);
                Console.WriteLine("Введите:");
                Console.WriteLine($"{"       "}1: bold");
                Console.WriteLine($"{"       "}2: italic");
                Console.WriteLine($"{"       "}3: underline");

                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    if (option == 1 || option == 2 || option == 3)
                    {
                        if (option == 3)
                        {
                            option++;
                        }
                        style ^= option;
                    }
                }
                else
                {
                    Console.WriteLine("Error! Option not found.");
                }
            } while (true);


        }

        [Flags]
        enum Styles
        {
            None,
            Bold,
            Italic,
            Underline = 4
        }
    }
}
