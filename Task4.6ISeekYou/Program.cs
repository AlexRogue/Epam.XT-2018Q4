using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task4._6ISeekYou.Searcher;

namespace Task4._6ISeekYou
{
    class Program
    {       
        private static void Main(string[] args)
        {
            Random random = new Random();
            
            int[] array = new int[1000];
            for(int i = 0; i < array.Length; i++)
            { 
                array[i] = random.Next(-1000, 1000);
            }

            TimeComparer timeComparer = new TimeComparer();
            timeComparer.Compare(array);   
        }
    }
}
