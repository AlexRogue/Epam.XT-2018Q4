using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._4.MyString
{
   public  class MyString
    {
        private readonly char[] _array;
        private int Length { get; }
        
        public char this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }
        
        
        public MyString(string input)
        {
            Length = input.Length;
            _array = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                _array[i] = input[i];
            }

        }
        
        
        public override string ToString()
        {
            return new string(_array);
        }
        
        

        public MyString(char[] input)
        {
            _array = input;

        }

        public bool CompareTo(char[] input)
        {
            bool result = false;
            if (_array.Length == input.Length)
            {
                for (int i = 0; i < _array.Length; i++)
                {
                    result = _array[i] == input[i];
                    if (!result)
                    {
                        break;
                    }
                }

            }

            return result;
        }

        

        public char[] Append(char[] input)
        {
            char[] output = new char[_array.Length + input.Length];
            for (int i = 0; i < _array.Length; i++)
            {
                output[i] = _array[i];

            }
            for (int j = _array.Length, i = 0; j < output.Length; j++, i++)
            {
                output[j] = _array[i];
            }

            return output;
        }

       

        public static implicit operator String(MyString mystring)
        {
            return new string(mystring._array);
        }

        
                
        public int IndexOf(char symbol)
        {
            int index = -1; 
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == symbol)
                {
                    index = i;
                    break;
                }

            }

            return index;
        }

        
        public static MyString[] operator + (MyString myStringOne, MyString myStringTwo)
        {
            MyString[] myStrings = {myStringOne, myStringTwo};
            return myStrings;
        }
    }
}