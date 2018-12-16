using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4.NumberArraySum
{
    static class Extension
    {
        public static T MySum<T>(this T[] ar)
        {
            if (ar is int[])
            {
                int sum = 0;
                foreach (var n in ar as int[])
                {
                    sum += n;
                }
                return  (T)Convert.ChangeType(sum, typeof(T));
            }
            if (ar is double[])
            {
                double sum = 0;
                foreach (var n in ar as double[])
                {
                    sum += n;
                }
                return (T)Convert.ChangeType(sum, typeof(T));
            }
            if (ar is float[])
            {
                float sum = 0;
                foreach (var n in ar as float[])
                {
                    sum += n;
                }
                return (T)Convert.ChangeType(sum, typeof(T));
            }
            if (ar is decimal[])
            {
                decimal sum = 0;
                foreach (var n in ar as decimal[])
                {
                    sum += n;
                }
                return (T)Convert.ChangeType(sum, typeof(T));
            }
            if (ar is short[])
            {
                short sum = 0;
                foreach (var n in ar as short[])
                {
                    sum += n;
                }
                return (T)Convert.ChangeType(sum, typeof(T));
            }

            return default(T);
            
        }
    }
}
