using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._1.Round
{
    class Program
    {
        static void Main(string[] args)
        {
            Round round = new Round();
            do
            {
                Console.WriteLine("Введите:");
                Console.WriteLine($"{"       "}1: Show circumference of round");
                Console.WriteLine($"{"       "}2: Show area of round");
                Console.WriteLine($"{"       "}3: Show center coordinates of round");
                Console.WriteLine($"{"       "}4: Create new round");

                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    switch (option)
                    {
                        case 1:
                            round.ShowCircumference();
                            break;

                        case 2:
                            round.ShowArea();
                            break;

                        case 3:
                            round.ShowCenter();
                            break;

                        case 4:
                            round = new Round();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error! Option not found.");
                }
            } while (true);
        }
    }
}
