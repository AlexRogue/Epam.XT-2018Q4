using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Task._3._3.DynamicArray;

namespace Task._3._3.DynamicArray
{
    public class DynamicArray<T> : IEnumerable, IEnumerable<T>, ICloneable, IEnumerator
    {
        
        private T[] _array;
        public int Length => _array.Length;
        public int Capacity => _size;
        private int _cursor = -1;
        private int _size;
        
        public object Current => _array[_cursor];

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _array.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return _array[index];
            }
        }


        public DynamicArray()
        {
            _array = new T[8];
            _size = _array.Length;
        }
        
        
        public DynamicArray(int i)
        {
            _array = new T[i];
            _size = _array.Length;
        }
        
        
        public DynamicArray(IEnumerable<T> collection)
        {
            _array = new T[collection.Count()];
            foreach (var element in collection)
            {
                for (var i = 0; i < _array.Length; i++)
                {
                    _array[i] = element;
                }
            }
            _size = _array.Length;
        }

     

        private void Resize(int size)
        {
            if (_array.Length == size)
            {
                while (_array.Length == size)
                {
                    NextSize();
                }
 
                T[] newArray = new T[_size];
 
                for (int i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }
 
                _array = newArray;
            }
        }
        
//        public void Add(T elem)
//        {
//            Resize(_size);
//            _array[_size] = elem;
//            _size++;
//        }
        
        
        public void Add<Z>(Z? elem) where Z : struct 
        {
            Z?[] d = new Z?[4];
            d[0] = elem;
            foreach (var x in d)
            {
                if(x == null)
                    Console.WriteLine("null");
            }
            Console.WriteLine();
            foreach (var x in d)
            {
                    Console.WriteLine(x);
            }
        }
        
        public void Add(T elem)
        {
            T[] a = new T[4];
            a[0] = elem;
        }
        
        private void NextSize()
        {
            _size *= 2;
        }
        
        public T Insert(T elem, int index)
        {
            Resize(index);
            
            
 
            T tmp1 = _array[index];
            T tmp2;
            T tmp3;
 
            try { tmp2 = _array[index + 1]; }
            catch { return default(T); }
 
            try { tmp3 = _array[index + 2]; }
            catch { return default(T); }
 
            int i = index;
 
            for (; i != _array.Length; i++)
            {
                _array[i + 1] = tmp1;
                tmp1 = tmp2;
                tmp2 = tmp3;
 
                try { tmp3 = _array[i + 3]; }
                catch { break; }
            }
 
            _array[index] = elem;
            //count++;
            return default(T);
        }

        public bool Remove(int index)
        {
            if (index < 0 || index > _array.Length)
            {
               _array = _array.Except(new [] {_array[index]}).ToArray();
               return true;
            }

            return false;
        }

//        public void Add(T element)
//        {
//            if (element is string)
//            {
//                for (int i = 0; i < array.Length; i++)
//                {
//                    if (array[i] == null)
//                    {
//
//                    }
//                }
//            }
//        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _array)
            {
                yield return item;
            }
        }
 
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public object Clone()
        {
            T[] newArray = new T[_array.Length];
            for (int i = 0;  i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            return newArray;
        }

        public bool MoveNext()
        {
            if (_cursor < _array.Length)
                _cursor++;

            return(_cursor != _array.Length);
        }

        public void Reset()
        {
            _cursor = -1;
        }

        
    }
}

