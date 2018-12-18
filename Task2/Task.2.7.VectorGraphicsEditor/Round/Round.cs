using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._2._7.VectorGraphicsEditor
{
    class Round : Circle, IFigure
    {
        public double area => Math.PI * Math.Pow(Radius, 2);

        public new void Show()
        {
            Console.WriteLine("Это круг");
            Console.WriteLine($"Центр окружности ({CenterX};{CenterY})");
            Console.WriteLine($"Радиус {Radius}");
            Console.WriteLine($"Длина окружности {Circumference}");
            Console.WriteLine($"Площадь круга {area}");
        }
    }
}
