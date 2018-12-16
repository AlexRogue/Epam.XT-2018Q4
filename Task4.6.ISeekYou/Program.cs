using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_5.ToIntOrNotToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            string str = Console.ReadLine();
            str.CheckInt();
        }
    }
}
