using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1._1.Rectangle
{
    class Program
    {

        static string[] rectangle = new string[2];

        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            bool checker;
            do
            {
                checker = false;
                for (int i = 0; i < rectangle.Length; i++)
                {
                    Console.WriteLine($"Enter your {i + 1} number");
                    rectangle[i] = Console.ReadLine();
                    
                    if (IsDouble(rectangle[i]) || IsLetter(rectangle[i]))
                    {
                        checker = true;
                        break;
                    }
                    if (int.Parse(rectangle[i]) <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"You entered inappropriate character. Try again.");
                        checker = true;
                        break;
                    }
                }
            } while (checker);

            int v = Convert.ToInt32(rectangle[0])  * Convert.ToInt32(rectangle[1]);
            Console.WriteLine($"Your answer: {v}");

        }

    public static bool IsLetter(string values)
    {
            var y =  values.ToCharArray();
            foreach (var n in y)
            {
                if (Char.IsLetter(n))
                {
                    return true;
                }
            }
            return false;
    }

        public static bool IsDouble(string values)
        {
            Decimal.TryParse(values, out decimal d);
            if (d % 1 > 0)
            {
                  return true;
            };
            return false;
        }

    }
}
