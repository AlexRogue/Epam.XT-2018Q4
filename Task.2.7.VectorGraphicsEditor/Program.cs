using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._2._7.VectorGraphicsEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какую фигуру хочешь?");



            Console.WriteLine("Нажми 1, если хочешь линию");
            Console.WriteLine("Нажми 2, если хочешь окружность");
            Console.WriteLine("Нажми 3, если хочешь прямоугольник");
            Console.WriteLine("Нажми 4, если хочешь круг");
            Console.WriteLine("Нажми 5, если хочешь кольцо");

            int.TryParse(Console.ReadLine(), out int option);
            new Context(option);
                 
            
        }
    }
}
