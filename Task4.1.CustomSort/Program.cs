using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._1.CustomSort
{
    class SportCar
    {
        public int Engine {get;}
        public double FuelConsumption { get; }
        public string BrandName { get; }


        public SportCar(int engine, double fuelConsumption, string brandName)
        {
            Engine = engine;
            FuelConsumption = fuelConsumption;
            BrandName = brandName;
        }
    }


    class Expert
    {
        public int CompareByEngine(SportCar one, SportCar two)
        {   
            if (ReferenceEquals(one, two)) return 0;
            if (ReferenceEquals(one, null)) return -1;
            if (ReferenceEquals(two, null)) return 1;

            return one.Engine.CompareTo(two.Engine);
        }

        public int CompareByFuelConsumption(SportCar one, SportCar two)
        {
            if (ReferenceEquals(one, two)) return 0;
            if (ReferenceEquals(one, null)) return -1;
            if (ReferenceEquals(two, null)) return 1;

            return one.FuelConsumption.CompareTo(two.FuelConsumption);
        }

        public int CompareByBrandName(SportCar one, SportCar two)
        {
            if (ReferenceEquals(one, two)) return 0;
            if (ReferenceEquals(one, null)) return -1;
            if (ReferenceEquals(two, null)) return 1;

            return one.BrandName.CompareTo(two.BrandName);
        }

        public void ShowDifference(SportCar[] sportCars, String presentation)
        {
            Console.WriteLine();
            Console.WriteLine(presentation);
            foreach (var car in sportCars)
            {
                Console.Write(car.BrandName);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { new SportCar(460, 15.3, "Porsche"), new SportCar(670,  17.2, "Lamborghine"), new SportCar(650, 16.4, "Nissan GTR") };
            Expert expert = new Expert();
            CustomSort customSort = new CustomSort();
            customSort.Sort(array, expert.CompareByEngine);
            expert.ShowDifference(array, "Engine");
            customSort.Sort(array, expert.CompareByFuelConsumption);
            expert.ShowDifference(array, "Fuel consumption");
            customSort.Sort(array, expert.CompareByBrandName);
            expert.ShowDifference(array, "Brand name");
        }
    }
}
