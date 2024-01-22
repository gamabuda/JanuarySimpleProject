using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core
{
    public class DynamicArray<T>
    {
        private T[] _array;
        private int _count;

        public DynamicArray(T value)
        {
            _array = new T[1] { value };
            _count = 0;
        }

        public void Add(T str)
        {
            int oldSize = _array.Length;
            T[] newArray = new T[oldSize + 10];

            for (int i = 0; i < _array.Length; i++) { newArray[i] = _array[i]; }

            _array = newArray;
            _array[_count] = str;
            _count++;
            
        }


        public void Remove(T str)
        {
            int index = Array.IndexOf(_array, str, 0, _count);

            if (index != -1)
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

        public void Print()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.Write(_array[i] + " ");
            }
            Console.WriteLine();
        }

        public void Replace(T oldValue, T newValue)
        {
            int index = Array.IndexOf(_array, oldValue);
            _array[index] = newValue;
        }

        public int Count
        {
            get { return _count; }
        }
    }
}
