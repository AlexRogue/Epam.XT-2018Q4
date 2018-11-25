using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1._11.AverageStringLenght
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsArray = new string[10];
            string normolizedString = null;
            string strFirst = "Hello, folks! What do 67.56 we got here 23?";
            foreach (char a in strFirst)
            {
                if (Char.IsPunctuation(a) || Char.IsDigit(a))
                {
                    normolizedString += string.Empty;
                }
                else
                {
                    normolizedString += a;
                }
            }
            wordsArray = normolizedString.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            int[] intArray = new int[wordsArray.Length];
            for (int i = 0; i < wordsArray.Length; i++)
            {
                bool h = string.IsNullOrEmpty(wordsArray[i]);
                if (!string.IsNullOrEmpty(wordsArray[i]))
                {
                    intArray[i] = wordsArray[i].Length;
                }
            }
            Array.Sort(intArray);
            int mid = intArray[intArray.Length / 2];
        }
    }
}
