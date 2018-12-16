using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._4._2.CustomSortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomSort sort = new CustomSort();
            var arr = new[] { "asd,", "bbb", "ccc", "ddd", "aac", "aad", "abc", "dfsdfdsfsdfds" };
            sort.Sort(arr, sort.StringSort);
            foreach (var w in arr)
            {
                Console.WriteLine(w);
            }
        }
    }
}
