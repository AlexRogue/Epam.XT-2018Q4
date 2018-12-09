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
            var resolver = new TextResolver();
            var counter = new WordsCounter();
            counter.CountEqualWordsIn(resolver.EnglishText);
        }
    }



    internal class WordsCounter
    {
        List<string> recivedWords = new List<string>();
        private List<string> _textWords;

        public WordsCounter()
        {
            do
            {
                Console.WriteLine("Enter english words that you want to find in text. Use whitespace or dots to separate words");
                _textWords = Console.ReadLine()?.Split(' ', '.').ToList();
            } while (_textWords == null || _textWords[0] == "");
        }

        public void CountEqualWordsIn(List<string> textCollection)
        {
            int i;
            var entranceIndexer = new List<string>();
            foreach (var word in _textWords)
            {
                foreach (var wordFromTextCollection in textCollection)
                {
                    if (wordFromTextCollection.Equals(word,  StringComparison.InvariantCultureIgnoreCase))
                    {
                       entranceIndexer.Add(word);
                    }
                }

                if (entranceIndexer.Count != 0)
                {
                    Console.WriteLine($"You have {entranceIndexer.Count} entrance with word {entranceIndexer[0]}");
                    entranceIndexer.Clear();
                }
            }
        }
    }



    internal class TextResolver
    {
        private List<string> _text;
        public List<string> EnglishText => _text ?? GetClearWords();


        public TextResolver()
        {
            _text = GetText();
        }



        private List<string> GetText()
        {
            do
            {
                Console.WriteLine("Enter english text");
                _text = Console.ReadLine()?.Split(' ').ToList();
            } while (_text == null);

            return _text;
        }


        private List<string> GetClearWords()
        {
            var sb = new StringBuilder();
            foreach (var word in _text)
            {
                foreach (var c in word)
                {
                    if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                    {
                        sb.Append(c);

                    }
                }

                _text[_text.IndexOf(word)] = sb.ToString();
            }

            return _text;
        }
    }
}