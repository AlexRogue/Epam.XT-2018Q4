using System;


namespace Task._2._7.VectorGraphicsEditor
{
    class Circle : IFigure
    {
        public double Circumference { get; }

        public double Radius { get; }

        public double CenterX { get; }

        public double CenterY { get; }

        public Circle()
        {
            CenterX = InsertValue("Enter coordinates of center X");
            CenterY = InsertValue("Enter coordinates of center Y");
            Radius = RadiusCheck();
            Circumference = GetCircumference();
        }


        private static double InsertValue(string instruction)
        {
            Console.WriteLine(instruction);
            double value;
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("You entered inappropriate number. Enter value again");
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

        private double GetCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        public void Show()
        {
            Console.WriteLine("This is a Circle");
            Console.WriteLine($"Center of circle: {CenterX};{CenterY}");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Length: {Circumference}");
        }
    }
}
