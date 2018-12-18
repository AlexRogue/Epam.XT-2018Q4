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
        string centerXChecker;
        string centerYChecker;
        double value = 0;
        bool check;

        private double C => 2 * Math.PI * Radius;
        private double S => Math.PI * Math.Pow(Radius, 2);

        public Round()
        {
            Console.WriteLine("New Round created");
        }


        private double Radius
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

        private double CenterX
        {
            get
            {
                if (centerXChecker == null)
                {
                    Console.WriteLine("Insert coordinate of X (use comma instead of dot to separate fraction)");
                    centerX = CenterCoordinatesCheck(ref centerXChecker);
                }
                    return centerX;
            }
        }

        private double CenterY
        {
            get
            {
                if (centerYChecker == null)
                {
                    Console.WriteLine("Insert coordinate of Y (use comma instead of dot to separate fraction)");
                    centerY = CenterCoordinatesCheck(ref centerYChecker);
                }
                    return centerY;
            }
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

        private double CenterCoordinatesCheck(ref string coordinateChecker)
        {            
            do
            {
                coordinateChecker = Console.ReadLine();
                check = !double.TryParse(coordinateChecker, out value);
                if (check)
                {
                    Console.WriteLine("Try to insert coordinate again");
                }
            }
            while (check);
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
