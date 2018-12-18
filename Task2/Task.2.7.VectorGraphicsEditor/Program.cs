using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._2._7.VectorGraphicsEditor
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What figure do you want to create?");

                Console.WriteLine("Enter 1, if you want create a line");
                Console.WriteLine("Enter 2, if you want create a circle");
                Console.WriteLine("Enter 3, if you want create a rectangle");
                Console.WriteLine("Enter 4, if you want create a round");
                Console.WriteLine("Enter 5, if you want create a ring");

                var figure = new Context().GetFigure().ReturnConcreteFigure();
                figure.Show();
            }
        }
    }
}
