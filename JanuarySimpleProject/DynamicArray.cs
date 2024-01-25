using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject
{
    internal class DynamicArray<T> where T : IComparable<T>
    {
        private T[] _array; 
        private int _count;
        public DynamicArray()
        {
            _array = new T[4]; _count = 0;
        }
        public void Add(T str)
        {
            if (_count == _array.Length)
            {
             
              Resize();
            }
            _array[_count] = str;
            _count++;
        }
        public void Remove(T str)
        {
            int index = Array.IndexOf(_array, str, 0, _count); if (index != -1)
            {
                for (int i = 0; i < _count - 1; i++)
                {
                    _array[i] = _array[i + 1];
                }
                _count--;
            }
        }
        public bool Contains(T str)
        {
            return Array.IndexOf(_array, str, 0, _count) != -1;
        }

        private void Resize()
        {
            T[] temp = new T[_array.Length * 2];
            _array.CopyTo(temp, 0);
            _array = temp;   
        }
        public void Sort()
        {
            int step = _count / 2;
            while (step > 0)
            {
                for (int i = step; i < _count; i++)
                {
                    T temp = _array[i];
                    int j;
                    for (j = i; j >= step && _array[j - step].CompareTo(temp) > 0; j -= step)
                    {
                        _array[j] = _array[j - step];
                    }
                    _array[j] = temp;
                }
                step /= 2;
            }
        }

        public void Print()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_array[i] + "");
            }
            Console.WriteLine();
        }
        public void Clear()
        {
            List<T> newItems = _array.ToList();
            newItems.Clear();
            _array = newItems.ToArray();
            _count = 0;
        }
        public T[] GetArray()
        {
            return _array;
        }

        public int Count()
        {
            return _count;
        }

    }
}
