using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._4._2.CustomSortDemo
{
    public delegate int Compare<T>(T one, T two);

     class CustomSort
    {
        public void Sort<T>(T[] a, Compare<T> compare)
        {
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
        }


        public int StringSort(string a, string b)
        {
            if (a.Length != b.Length)
            {
                if (a.Length > b.Length)
                {
                    return -1;
                }
                return 1;
            }
            return a.CompareTo(b);
        }
    }
}
