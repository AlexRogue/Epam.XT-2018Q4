using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1._5.SumOfNumbers
{
    class Program
    {
        static List<int> list = new List<int>();
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    list.Add(i);    
                }
            }
           var y =  list.Sum();
        }
    }
}
