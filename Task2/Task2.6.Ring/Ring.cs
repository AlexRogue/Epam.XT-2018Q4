using System;
using Epam.Task2._1.Round;

namespace Task2._6.Ring
{
  
        class Ring 
    {
        private Round roundOne;
        private Round roundTwo;
        const double EPSILON = 0.001;

        private double GetArea() => Math.Abs(roundTwo.Area - roundOne.Area);

        public Ring()
        {
            do
            {
                Console.WriteLine("Введите данны ");
                roundOne = new Round();
                roundTwo = new Round();
            }
            while (!Checked()); 
        }


        private bool Checked()
        {
            double deltaR;
            var length = Math.Sqrt(Math.Pow((roundOne.CenterY - roundTwo.CenterY), 2) + Math.Pow((roundOne.CenterX - roundTwo.CenterX), 2));
            if (roundOne.Radius >= roundTwo.Radius)
            {
                deltaR = roundOne.Radius - roundTwo.Radius;
            }
            else
            {
                deltaR = roundTwo.Radius - roundOne.Radius;
            }

            if (Math.Abs(roundOne.Radius - roundTwo.Radius) < EPSILON)
            {
                Console.WriteLine("Вы описали окружность. Попробуйте еще раз!");
                return false;
            }

            if (length <= deltaR)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Внутреннее кольцо выходит за пределы наружного кольца");
                return false;
            }
        }

       


        public void Show()
        {
            if (roundOne.Radius >= roundTwo.Radius)
            {
                Console.WriteLine($"Координаты центра внешнего круга: ({roundOne.CenterX};{roundOne.CenterY})");
                Console.WriteLine($"Радиус внешнего круга равен: {roundOne.Radius}");
                Console.WriteLine($"Длина внешней окружности равна: {roundOne.Circumference}");
                Console.WriteLine($"Координаты центра внутреннего круга: ({roundTwo.CenterX};{roundTwo.CenterY})");
                Console.WriteLine($"Радиус внутреннего круга равен: {roundTwo.Radius}");
                Console.WriteLine($"Длина внутреннего окружности равна: {roundTwo.Circumference}");
            }
            else
            {
                Console.WriteLine($"Координаты центра внешнего круга: ({roundTwo.CenterX};{roundTwo.CenterY})");
                Console.WriteLine($"Радиус внешнего круга равен: {roundTwo.Radius}");
                Console.WriteLine($"Длина внешней окружности равна: {roundTwo.Circumference}");
                Console.WriteLine($"Координаты центра внутреннего круга: ({roundOne.CenterX};{roundOne.CenterY})");
                Console.WriteLine($"Радиус внутреннего круга равен: {roundOne.Radius}");
                Console.WriteLine($"Длина внутреннего окружности равна: {roundOne.Circumference}");
            }
            Console.WriteLine($"Площадь кольца {GetArea()}");
        }
    }
    }
