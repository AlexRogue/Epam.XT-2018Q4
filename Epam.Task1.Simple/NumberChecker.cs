using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Simple
{
    class NumberChecker
    {
        int number;

        public NumberChecker(int number)
        {
            this.number = number;
        }


        public bool IsPrime()
        {
            for (int i = 2; i < number; i++)
                if ((number % i) == 0) return false;
            return true;
        }
    }
}
