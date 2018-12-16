using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Task4._6ISeekYou
{
    class TimeComparer
    {
        Searcher searcher = new Searcher();
        Dictionary<string, TimeSpan> timeSpanCollection = new Dictionary<string, TimeSpan>();

        public void Compare(int[] array)
        {
            Stopwatch stopWatch = new Stopwatch();
            TimeSpan[] timeSpan = new TimeSpan[1000];

            for (int i = 0; i < 1000; i++)
            {
                stopWatch.Reset();
                stopWatch.Start();
                searcher.Search(array);
                stopWatch.Stop();

                timeSpan[i] = stopWatch.Elapsed;
            }
            double doubleAverageTicks = timeSpan.Average(ts => ts.Ticks);
            long longAverageTicks = Convert.ToInt64(doubleAverageTicks);
            TimeSpan d = new TimeSpan(longAverageTicks);
            timeSpanCollection.Add("Simple Method", d);



            for (int i = 0; i < 1000; i++)
            {
                stopWatch.Reset();
                stopWatch.Start();
                searcher.LinQSearch(array);
                stopWatch.Stop();

                timeSpan[i] = stopWatch.Elapsed;
            }
            double doubleAverageTicks1 = timeSpan.Average(ts => ts.Ticks);
            long longAverageTicks1 = Convert.ToInt64(doubleAverageTicks1);
            TimeSpan d1 = new TimeSpan(longAverageTicks1);
            timeSpanCollection.Add("LinQ", d1);


            for (int i = 0; i < 1000; i++)
            {
                stopWatch.Reset();
                stopWatch.Start();
                searcher.Search(array, new SearchWithCondition(searcher.SearchCondition));
                stopWatch.Stop();

                timeSpan[i] = stopWatch.Elapsed;
            }
            double doubleAverageTicks2 = timeSpan.Average(ts => ts.Ticks);
            long longAverageTicks2 = Convert.ToInt64(doubleAverageTicks2);
            TimeSpan d2 = new TimeSpan(longAverageTicks2);
            timeSpanCollection.Add("New Delegate", d2);

            for (int i = 0; i < 1000; i++)
            {
                stopWatch.Reset();
                stopWatch.Start();
                searcher.Search(array, searcher.search);
                stopWatch.Stop();

                timeSpan[i] = stopWatch.Elapsed;
            }
            double doubleAverageTicks3 = timeSpan.Average(ts => ts.Ticks);
            long longAverageTicks3 = Convert.ToInt64(doubleAverageTicks3);
            TimeSpan d3 = new TimeSpan(longAverageTicks3);
            timeSpanCollection.Add("Lambda", d3);

            for (int i = 0; i < 1000; i++)
            {
                stopWatch.Reset();
                stopWatch.Start();
                searcher.Search(array, searcher.anonymousSearch);
                stopWatch.Stop();

                timeSpan[i] = stopWatch.Elapsed;
            }
            double doubleAverageTicks4 = timeSpan.Average(ts => ts.Ticks);
            long longAverageTicks4 = Convert.ToInt64(doubleAverageTicks4);
            TimeSpan d4 = new TimeSpan(longAverageTicks4);
            timeSpanCollection.Add("Anonymous Method", d4);

            foreach (var element in timeSpanCollection)
            {
                Console.WriteLine($"Name of Method: {element.Key}. Avarage time: {element.Value}");
            }

            TimeSpan[] ta = { d, d1, d2, d3, d4 };
            var min = ta.Min();
            Console.WriteLine($"Minimum search time: {min}");
        }

       
    }
}
