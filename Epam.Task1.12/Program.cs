using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1._12
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "";
            string secondString = "";
            string resultString = "";
            Console.WriteLine("Введи первую строку");
            firstString = Console.ReadLine();
            Console.WriteLine("Введи вторую строку");
            secondString = Console.ReadLine();
            foreach (char ch in firstString)
                if (!secondString.Contains(ch))
                    resultString += ch;
                else
                {
                    resultString += ch;
                    resultString += ch;
                }
            Console.WriteLine($"Результат: {resultString}");
            Console.ReadKey();
        }
    }
}
