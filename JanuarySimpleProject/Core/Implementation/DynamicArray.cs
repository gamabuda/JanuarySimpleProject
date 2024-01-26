﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core.Implementation
{
    public class DynamicArray<T>
    {
        private T[] _values;
        private int _count;
        public DynamicArray()
        {
            _values = new T[0];
            _count = 0;
        }

        public DynamicArray(T value)
        {
            _values = new T[1] { value };
            _count = 1;
        }
        public T this[int index]
        {
            get { return _values[index]; }
            set { _values[index] = value; }
        }

        public void Add(T value)
        {
            if (_count != _values.Length)
            {
                _values[_count] = value;
            }
            else
            {
                T[] temp = new T[_values.Length * 2];
                _values.CopyTo(temp, 0);
                _values = temp;
                _values[_count] = value;
            }
            _count++;
        }

        public void Remove(T value)
        {

            int index = Array.IndexOf(_values, value);
            if (index != -1)
            {
                _values[index] = default(T);
                _values = _values.Where(a => a != null).ToArray();
            }
            else
            {
                throw new Exception("Элемента нет в массиве");
            }
            _count--;
        }

        public bool Contains(T value)
        {
            return _values.Contains(value);
        }

        public void Clear()
        {
            _values = new T[0];
        }

        public void Replace(T oldValue, T newValue)
        {
            int index = Array.IndexOf(_values, oldValue);
            _values[index] = newValue;
        }

        public IEnumerator<object> GetEnumerator()
        {
            for (int i = 0; i < _values.Length; i++)
            {
                yield return _values[i];
            }
        }
    }
}