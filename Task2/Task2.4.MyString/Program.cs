using System;

namespace Task2._4.MyString
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char[] array = { '1', '2', '3' };
            string str = "123";

            
            Console.WriteLine($"\nString: {str}");
            
            Console.Write("array: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            MyString ms = new MyString(str);
            var s = ms.ToString();

            Console.WriteLine();
            
            Console.WriteLine($"Index of '2': {ms.IndexOf('2')}");

            Console.WriteLine($"Compare string and array: {ms.CompareTo(array)}");

            char[] appendArr = ms.Append(array);

            Console.Write($"Append string with arr:");

            for (int i = 0; i < appendArr.Length; i++)
            {
                Console.Write($"{appendArr[i]}");
            }
           
            MyString myString2 = new MyString("234234234");            
            MyString myString1 = new MyString("asdasdasd");
            MyString[] msm = myString1 + myString2;
            Console.WriteLine();
            Console.WriteLine($"Number of elements inside msm: {msm.Length}");
        }
    }
}