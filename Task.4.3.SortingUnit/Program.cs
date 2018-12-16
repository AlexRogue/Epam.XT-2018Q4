using System;
using System.Threading;



namespace Task._4._3.SortingUnit
{
    class SportCar
    {
        public int Engine { get; }
        public double FuelConsumption { get; }
        public string BrandName { get; }


        public SportCar(int engine, double fuelConsumption, string brandName)
        {
            Engine = engine;
            FuelConsumption = fuelConsumption;
            BrandName = brandName;
        }


    }

    class ShowThread
    {
        public void RunT<T>(CustomSort<T> customSort, T[] array, Compare<T> CompareByBrandName)
        {
            Thread threadStart = new Thread(() => { customSort.Sort(array, CompareByBrandName); });
            threadStart.Start();
            customSort.SignalEvent.WaitOne();
            customSort.SignalEvent.Reset();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            SportCar sportCarOne = new SportCar(460, 15.3, "Porsche");
            SportCar sportCarTwo = new SportCar(670, 17.2, "Lamborghini");
            SportCar sportCarThree = new SportCar(550, 16.6, "BMW");
            var array = new[] { sportCarOne, sportCarTwo, sportCarThree };
            CustomSort<SportCar> customSort = new CustomSort<SportCar>();
 
            ShowThread show = new ShowThread();

            customSort.SortingFinished +=
            (sender, e) =>
        {
            Console.WriteLine("Sort finished");
        };

            show.RunT(customSort, array, CompareByBrandName);

            
        }

        public static int CompareByBrandName(SportCar one, SportCar two)
        {

                if (ReferenceEquals(one, two)) return 0;
                if (ReferenceEquals(one, null)) return -1;
                if (ReferenceEquals(two, null)) return 1;
                return one.BrandName.CompareTo(two.BrandName);
            
       }


    }
}
