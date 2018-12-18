using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._1.Round
{
    class Round
    {

        public double Area => Math.PI * Math.Pow(Radius, 2);
        private double C => 2 * Math.PI * Radius;
        private double S => Math.PI * Math.Pow(Radius, 2);
        
        public double Radius { get; }

        public double CenterX { get; }

        public double CenterY { get; }
        
        public double Circumference { get; }


        public Round()
        {
            Console.WriteLine("Create round");
            CenterX = InsertValue("Enter coordinates of center X");
            CenterY = InsertValue("Enter coordinates of center Y");
            Radius = RadiusCheck();
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
