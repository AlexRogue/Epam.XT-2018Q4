using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._2._7.VectorGraphicsEditor
{
    class Rectangle : IFigure
    {
        private double aX;
        private double aY;
        private double bX;
        private double bY;
        private double cX;
        private double cY;
        private double dX;
        private double dY;
        private double lengthAB;
        private double lengthBC;
        double angle;

        double S => lengthAB * lengthBC;
        double P => (lengthAB + lengthBC) * 2;

        public Rectangle()
        {
            aX = InsertValue("Введите координату х для точки А");
            aY = InsertValue("Введите координату y для точки А");
            bX = InsertValue("Введите координату х для точки B");
            bY = InsertValue("Введите координату y для точки B");

            do
            {
                cX = InsertValue("Введите координату х для точки C");
                cY = InsertValue("Введите координату y для точки C");
                angle = ((bX - aX) * (bX - cX) + (bY - aY) * (bY - cY));
                if (angle != 0)
                {
                    Console.WriteLine("Введите значение еще раз");
                }
            }
            while (angle != 0);

            dX = aX + cX - bX;
            dY = aY + cY - bY;

            lengthAB = CalculateLength(aX, bX, aY, bY);
            lengthBC = CalculateLength(bX, cX, bY, cY);
        }
        private double InsertValue(string comment)
        {
            double value;
            Console.WriteLine(comment);
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Введите значение еще раз");
            }
            return value;

        }
 

        private double CalculateLength(double startX, double endX, double startY, double endY)
        {
            return Math.Sqrt(Math.Pow((endY - startY), 2) + Math.Pow((endX - startX), 2));
        }

        public void Show()
        {
            Console.WriteLine("Это rectangle");
            Console.WriteLine($"Координаты точки A: {aX};{aY}");
            Console.WriteLine($"Координаты точки B: {bX};{bY}");
            Console.WriteLine($"Координаты точки C: {cX};{cY}");
            Console.WriteLine($"Координаты точки D: {dX};{dY}");
            Console.WriteLine($"Длина линии АB: {lengthAB}");
            Console.WriteLine($"Длина линии BC: {lengthBC}");
            Console.WriteLine($"P: {P}");
            Console.WriteLine($"S: {S}");
        }
    }
}
