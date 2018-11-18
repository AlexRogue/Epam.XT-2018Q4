using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.XT_2018Q4
{
    class StarProducer
    {
        int number;

        public StarProducer(int number)
        {
            this.number = number;
        }


        public void GenerateStarField()
        {
            int dividedLine = number / 2;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("");
                if (dividedLine != i)
                {
                    for (int a = 0; a < number; a++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int a = 0; a < number; a++)
                    {
                        if (dividedLine != a)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }
        }


    }
}
