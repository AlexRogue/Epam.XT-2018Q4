using System;


namespace Task._2._7.VectorGraphicsEditor
{
    class Circle : IFigure
    {
        private double centerX;
        private double centerY;
        private double radius;
        private double circumference;

        public double Circumference => circumference;
        public double Radius => radius;
        public double CenterX => centerX;
        public double CenterY => centerY;

        public Circle()
        {
            centerX = InsertValue("Введите координату центра X");
            centerY = InsertValue("Введите координату центра Y");
            radius = RadiusCheck();
            circumference = GetCircumference();
        }


        private double InsertValue(string instruction)
        {
            Console.WriteLine(instruction);
            double value;
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Введите значение еще раз");
            }
            return value;
        }

        private double RadiusCheck()
        {
            Console.WriteLine("Enter Radius (use comma instead of dot to separate fraction)");
            double value = 0;
            while (!double.TryParse(Console.ReadLine(), out value) | value < 0)
            {
                Console.WriteLine("Try to enter Radius again");
            }
            return value;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public void Show()
        {
            Console.WriteLine("Это окружность");
            Console.WriteLine($"Центр окружности ({centerX};{centerY})");
            Console.WriteLine($"Радиус {radius}");
            Console.WriteLine($"Длина окружности {circumference}");
        }
    }
}
