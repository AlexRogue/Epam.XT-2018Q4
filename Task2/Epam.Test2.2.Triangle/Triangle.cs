using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Test2._2.Triangle
{
    class Triangle
    {
        double sideA;
        double sideB;
        double sideC;
        double area;
        double perimetr;

        private double Area => CheckArea();

        private double Perimetr => CheckPerimetr();

         private double CheckArea()
        {
            if (area == 0)
            {
                area = (SideA + SideB + SideC)/2;
            }
            return area;
        }

        private double CheckPerimetr()
        {
            if (perimetr == 0)
            {
                perimetr = SideA + SideB + SideC;
            }
            return perimetr;
        }


        private double SideA
        {
            get
            {
                if (sideA <= 0)
                {
                    Console.WriteLine("Enter side A (use comma instead of dot to separate fraction)");
                    sideA = CheckSide();
                }
                return sideA;
            }
        }

        private double SideB
        {
            get
            {
                if (sideB <= 0)
                {
                    Console.WriteLine("Enter side B (use comma instead of dot to separate fraction)");
                    sideB = CheckSide();
                }
                    return sideB;
            }
        }

        private double SideC
        {
            get
            {
                if (sideC <= 0)
                {
                    Console.WriteLine("Enter side C (use comma instead of dot to separate fraction)");
                    sideC = CheckSide();
                }
                return sideC;
            }
        }

        public void SetSides()
        {
            Console.WriteLine($"Enter side A: {SideA}");
            Console.WriteLine($"Enter side B: {SideB}");
            Console.WriteLine($"Enter side C: {SideC}");
        }

        private double CheckSide()
        {
            double value = 0;
            while (!double.TryParse(Console.ReadLine(), out value) | value <= 0)
            {
                Console.WriteLine("Try to insert another value again"); 
            }
            return value;
        }

        private bool IsTriangleExist()
        {
            while (!(this.SideA < this.SideB + this.SideC) & !(this.SideB < this.SideA + this.SideC) & !(this.SideC < this.SideA + this.SideB))
            {
                Console.WriteLine("The Triangle is exist! Insert length of sides again");
                return true;
            }
            Console.WriteLine("The Triangle doesn't exist!");
            return false;
        }

         

        public void ShowArea()
        {
            if (IsTriangleExist())
            {
                Console.WriteLine($"Area equals: {Area}");
            }
        }

        public void ShowPerimetr()
        {
            if (IsTriangleExist())
            {
                Console.WriteLine($"Perimetr equals: {Perimetr}");
            }
        }
    }
}
