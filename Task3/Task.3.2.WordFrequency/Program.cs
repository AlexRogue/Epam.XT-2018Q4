using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;

namespace Task._3._2.WordFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            var separator = new Separator();
            separator.GetText();
            separator.Show(separator.CleanWords());
            separator.CountWords();
        }
    }
}



