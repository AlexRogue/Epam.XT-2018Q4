using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Task._3._3.Dynamic_arrayay;

namespace Task._3._3.Dynamic_arrayay
{
    public class Dynamic_arrayay<T> : IEnumerable, IEnumerable<T>, IEnumerator
    {
        
        private T[] _array;
        public int Length => _array.Length;
        public int Capacity => _size;
        private int _cursor = -1;
        private int _size;
        private int Count;
      
        
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


        public Dynamic_arrayay()
        {
            _array = new T[8];
            _size = _array.Length;
        }
        
        
        public Dynamic_arrayay(int i)
        {
            _array = new T[i];
            _size = _array.Length;
        }
        
        
        public Dynamic_arrayay(IEnumerable<T> collection)
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

    

        public void Add(T new_element)
        {
            if (Count + 1 < Capacity)
            {
                if (Count == 0)
                {
                    _array[0] = new_element;
                }
                else
                {
                    _array[Count] = new_element;
                }

                Count++;
            }

            else
            {
                T[] buffer = new T[2 * Capacity];
                _size = 2 * Capacity;
                for (int i = 0; i < Count; i++)
                {
                    buffer[i] = _array[i];
                }
                buffer[Count] = new_element;
                _array = buffer;

                Count++;
            }

        }

        public void AddRange(IEnumerable<T> collection)
        {
            if (Capacity < (Count + collection.Count()))
            {
                _size = Count + collection.Count();
                T[] buffer = new T[Capacity];

                for (int i = 0; i < Count; i++)
                {
                    buffer[i] = _array[i];
                }
                for (int i = Count; i < Capacity; i++)
                {
                    buffer[i] = ((T[])collection)[i - Count];
                }

                _array = buffer;
                Count = Capacity;
            }
            else
            {

                T[] buffer = new T[Capacity];


                for (int i = 0; i < Count; i++)
                {
                    buffer[i] = _array[i];
                }
                for (int i = Count; i < Count + collection.Count(); i++)
                {
                    buffer[i] = ((T[])collection)[i - Count];
                }

                _array = buffer;
                Count = Count + collection.Count();
            }
        }


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




        public bool MoveNext()
        {
            if (_cursor < _array.Length)
                _cursor++;

            return (_cursor != _array.Length);
        }

        public void Reset()
        {
            _cursor = -1;
        }


        public bool Remove(int index)
        {
            if (index < 0 || index > _array.Length)
            {
                _array = _array.Except(new [] { _array[index]}).ToArray();
               return true;
            }

            return false;
        }


        public bool Insert(T new_element, int index)
        {
            bool success = false;

            if (index < 0 || index > Count)
            {
                throw new ArgumentOutOfRangeException($"index:{index}", "Index is out of _arrayay's range");
            }

            else if (index == Count & Count < Capacity)
            {
                _array[index] = new_element;
                Count++;
            }

            else if (index == Capacity - 1 & index == Count - 1)
            {
                T[] buffer = new T[Capacity + 1];
                for (int i = 0; i < Count - 1; i++)
                {
                    buffer[i] = _array[i];
                }
                buffer[index] = new_element;
                buffer[index + 1] = _array[index];
                _array = buffer;
                _size++;
                Count++;
                success = true;

            }

            else if (index < Count & Count == Capacity)
            {
                T[] buffer = new T[Capacity + 1];
                for (int i = 0; i < index; i++)
                {
                    buffer[i] = _array[i];
                }
                buffer[index] = new_element;
                for (int i = index + 1; i < Count + 1; i++)
                {
                    buffer[i] = _array[i - 1];
                }
                _array = buffer;
                _size++;
                Count++;
                success = true;

            }

            else if (index < Count & Count < Capacity)
            {
                T[] buffer = new T[Capacity];
                for (int i = 0; i < index; i++)
                {
                    buffer[i] = _array[i];
                }
                buffer[index] = new_element;
                for (int i = index + 1; i < Count + 1; i++)
                {
                    buffer[i] = _array[i - 1];
                }
                _array = buffer;

                Count++;
                success = true;

            }

            return success;
        }
        
    }
}

