using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._1.Round
{
    class Round
    {
        double radius;
        double centerX;
        double centerY;

        public double C => 2 * Math.PI * Radius;
        public double S => Math.PI * Math.Pow(Radius, 2);

        public Round()
        {
            Console.WriteLine("New Round created");
        }
        

        public double Radius
        {
            get
            {
                if (radius == 0)
                {
                    radius = RadiusCheck();
                }
                    return radius;
            }
        }

        public double CenterX
        {
            get
            {
                if (centerX == 0)
                {
                    Console.WriteLine("Insert coordinate of X (use comma instead of dot to separate fraction)");
                    centerX = CenterCheck();
                }
                    return centerX;
            }
        }

        public double CenterY
        {
            get
            {
                if (centerY == 0)
                {
                    Console.WriteLine("Insert coordinate of Y (use comma instead of dot to separate fraction)");
                    centerY = CenterCheck();
                }
                    return centerY;
            }
        }


        private double RadiusCheck()
        {
            Console.WriteLine("Insert Radius (use comma instead of dot to separate fraction)");
            double value = 0;   
            while (!double.TryParse(Console.ReadLine(), out value) | value <= 0)
            {
                Console.WriteLine("Try to insert Radius again");
            }
            return value;
        }

        private double CenterCheck()
        {
            double value = 0;
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Try to insert coordinate again");
            }
            return value;
        }

        public void ShowRadius()
        {
            Console.WriteLine($"Radius of round: {Radius}");
        }

        public void ShowCenter()
        {
            Console.WriteLine($"Center coordinates of round: X = {CenterX}; Y = {CenterY}");
        }

        public void ShowCircumference()
        {
            Console.WriteLine($"Circumference of round: {C}");
        }

        public void ShowArea()
        {
            Console.WriteLine($"Area of round: {S}");
        }

    }
}
