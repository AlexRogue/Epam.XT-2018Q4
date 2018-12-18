using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Test2._2.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle();
            while (true)
            {
                
                    Console.WriteLine("Insert:");
                    Console.WriteLine("       1: Set length of sides");
                    Console.WriteLine("       2: Show area of Triangle");
                    Console.WriteLine("       3: Show perimetr of Triangle");
                    Console.WriteLine("       4: Create new Triangle");
                    Console.WriteLine("       5: Show Triangle sides");
                    if (int.TryParse(Console.ReadLine(), out var option))
                    {
                        switch (option)
                        {
                            case 1:
                                triangle = new Triangle();
                                triangle.SetSides();
                                break;

                            case 2:
                                triangle.ShowArea();
                                break;

                            case 3:
                                triangle.ShowPerimetr();
                                break;

                            case 4:
                                triangle = new Triangle();
                                break;

                            case 5:
                                triangle.SetSides();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error! Option not found.");
                    }
 
                
            }
       }
    }
}
