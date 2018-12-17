using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Task3._1.Lost
{
    class Program
             {
                 static void Main(string[] args)
                 {
                      int.TryParse(Console.ReadLine(), out var n);            
                      var listOfNumbers = new List<int>();
         
                      for (var i = 0; i < n; i++)
                      {
                         listOfNumbers.Add(i);
                      }
         
                     var resetIndex = 0;
                     do
                     {
                         for (var a = 1; a < listOfNumbers.Count; a++)
                         {
                             if (resetIndex == -1)
                             {
                                 a = 0;
                             }                       
                             listOfNumbers.RemoveAt(a);
                             resetIndex++;           
                         }
         
                         resetIndex -= listOfNumbers.Count;
                         foreach (var x in listOfNumbers)
                         {
                             Console.Write(x);
                         }
                         Console.WriteLine();
                     } while (listOfNumbers.Count != 1);
                 }
    }
}

