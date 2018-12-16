using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4.NumberArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            var sum = nums.MySum();
            Console.WriteLine(sum);

            double[] numsD = { 1.23, 2.23, 3.34, 4.5, 5.9 };
            var sumD = numsD.MySum();
            Console.WriteLine(sumD);
        }
    }
}
