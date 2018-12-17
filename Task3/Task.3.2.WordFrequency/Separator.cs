using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Separator
{
    private char[] delChars = { ' ', '.', '\n' };
    private int count = 1;
    private List<string> separateText = new List<string>();
    private int i;

    public void GetText()
    {
        Console.WriteLine("Enter your text.");
        separateText = Console.ReadLine().Split(delChars, StringSplitOptions.RemoveEmptyEntries).ToList();
    }

 
    public List<string> CleanWords()
    {
        var sb = new StringBuilder();

        for (int i = 0; i < separateText.Count; i++)
        {
            var word = separateText[i];

            for (int a = 0; a < word.Length; a++)
            {
                var c = word[a];
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    sb.Append(c);
                }

            }
            separateText[separateText.IndexOf(word)] = sb.ToString();
            sb.Clear();
        }

        return separateText;
    }


    public void CountWords()
    {
        for (i = 1; separateText.Count > 1; i++)
        {
            if (separateText[0] == separateText[i])
            {
                count++;
                separateText.RemoveAt(i);
                i--;
            }
            if (i >= (separateText.Count - 1))
            {
                Console.WriteLine($"Word {separateText[0]} has {count} copies.");
                separateText.RemoveAt(0);
                i = 0;
                count = 1;
            }
        }
    }

    public void Show(List<string> t)
    {
        for (int i = 0; i < t.Count; i++)
        {
            Console.WriteLine(t[i]);
        }
    }
}
