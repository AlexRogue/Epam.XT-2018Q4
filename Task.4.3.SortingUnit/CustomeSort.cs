using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task._4._3.SortingUnit
{
    public delegate int Compare<T>(T one, T two);

    class CustomSort<T>
    {
        public  ManualResetEvent SignalEvent = new ManualResetEvent(false);
        public delegate void EventHandler(object sender, StateChangedEventArgs e);
        public event EventHandler<StateChangedEventArgs> SortingFinished;


        public void Sort(T[] a, Compare<T> compare)
        {
     
                if (compare == null)
                {
                    throw new ArgumentException();
                }
   
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (compare(a[j], a[i]) < 0)
                        {
                            var temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                
            }
          SortingFinished(this, new StateChangedEventArgs(a));
          SignalEvent.Set();
        }

        public class StateChangedEventArgs : EventArgs
        {
            public StateChangedEventArgs(T[] array)
            {
              this.array = array;
                Show(array);
            }

            private T[] array { get; }

            private void Show(T[] array)
            {
                if (array is SportCar[])
                {
                    foreach (var car in array as SportCar[])
                    {
                        Console.WriteLine(car.BrandName);
                    }
                }
                else
                {
                    foreach (var value in array)
                    {
                        Console.WriteLine(value);
                    }
                }
            }
            
        }
    }
}
