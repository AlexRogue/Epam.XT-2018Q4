using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._2._7.VectorGraphicsEditor
{
    public class Line : IFigure
    {
        double startX;
        double startY;
        double endX;
        double endY;

        public Line()
        {
            double[] coordinates = { startX, startY, endX, endY };
            foreach (var coordinate in coordinates)
            {
                InsertValue(coordinate);
            }
        }

        private void InsertValue(double value)
        {
            while(!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Введите значение еще раз");
            }
        }

        public void Build()
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
           Console.WriteLine("Это линия");
           Console.WriteLine($"Координата точки A({startX};{startY})");
           Console.WriteLine($"Координата точки B({endX};{endY})");
        }
    }
}
