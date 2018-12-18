using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._2._7.VectorGraphicsEditor
{
    public class Line : IFigure
    {
        private double startX;
        private double startY;
        private double endX;
        private double endY;
        private double lenght;

        public Line()
        {
            startX = InsertValue("Точка А. Введите координату Х:"); 
            startY = InsertValue("Точка А. Введите координату Y:");
            endX = InsertValue("Точка B. Введите координату Х:");
            endY = InsertValue("Точка B. Введите координату Y:");
            lenght = Lenghts();
        }

        private double InsertValue(string instruction)
        {
            Console.WriteLine(instruction);
            double value;
            while(!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Введите значение еще раз");
            }
            return value;
        }

        public void Show()
        {
           Console.WriteLine("Это линия");
           Console.WriteLine($"Координата точки A({startX};{startY})");
           Console.WriteLine($"Координата точки B({endX};{endY})");
           Console.WriteLine($"Lenght :{lenght}");
        }

        public double Lenghts()
        {
            return Math.Sqrt(Math.Pow((endY - startY),2) + Math.Pow((endX - startX),2));
        }


    }
}
