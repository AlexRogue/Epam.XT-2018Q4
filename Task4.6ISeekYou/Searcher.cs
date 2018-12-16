using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._6ISeekYou
{
    public delegate bool SearchWithCondition(int i);
    class Searcher
    {       

        public List<int> Search(int[] array, SearchWithCondition del = null)
        {
            List<int> positiveArr = new List<int>();
            foreach (var num in array)
            {
                if (del != null)
                {
                    if (del(num))
                    {
                        positiveArr.Add(num);
                    }
                }
                else
                {
                    if (num > 0)
                    {
                        positiveArr.Add(num);
                    }
                }
            }
            return positiveArr;
        }


        public List<int> LinQSearch(int[] array)
        {
            List<int> positiveArr = array.Where(x => x >= 0).ToList();
            return positiveArr;
        }

       

        public  bool SearchCondition(int i)
        {
            if (i > 0)
            {
                return true;
            }
            return false;
        }


       public SearchWithCondition search = (int i) =>
        {
            if (i > 0)
            {
                return true;
            }
            return false;
        };



       public SearchWithCondition anonymousSearch = delegate (int i)
        {
            if (i > 0)
            {
                return true;
            }
            return false;
        };
    }
}
