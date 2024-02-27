using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Diagnostics.Metrics;

namespace JanuarySimpleProject
{
   public class DynamicArray<T> where T : IComparable<T>
    {
        private int _count;
        private T[] _values;
        public T Value { get; set; }
        public int Count { get { return _count; } }

        public DynamicArray(int len)
        {
            _values = new T[len];
            _count = 0;
        }

        public DynamicArray()
        {
        }

        private void IncreaseArray()
        {
            int newCount = _count + _count / 2;
            if (_count == 0)
            {
                newCount = 10;
            }

            var newArray = new T[newCount];
            for (int i = 0; i < _count; i++)
            {
                newArray[i] = _values[i];
            }

            _values = newArray;
        }

        public void Add(T item)
        {
            if (_count == _values.Length)
            {
                IncreaseArray();
            }

            _values[_count] = item;
            _count++;
        }
        public void Remove(T item)
        {
            int index = Array.IndexOf(_values, item, _count);
            if (_count == 0)
            {
                throw new Exception("Массив пуст");
            }

            if (index >= 0)
            {
                for (int i = index; i < _count - 1; i++)
                {
                    _values[i] = _values[i + 1];
                }
                _count--;
                if (_count == 0)
                {
                    throw new Exception("значений нет");
                }

            }
        }

        public bool Contains(T _item)
        {
            if (_values.Contains(_item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Print()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_values[i] + " ");
            }
            Console.WriteLine();
        }
        public T[] GetArray()
        {
            T[] array = new T[_count];

            for (int i = 0; i < _count; i++)
            {
                if (_values[i] != null)
                {
                    array[i] = _values[i];
                    _values = array;
                }
            }
            return array;
        }
        public void Clear()
        {
            _values = new T[6];
            _count = 0;
        }
        public int BinarySearch(T value)
        {
            return Array.BinarySearch(_values, 0, _values.Length, value);
        }
    }
}
