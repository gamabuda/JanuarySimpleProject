using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core
{
    public class DynamicArray<T>
    {
        public T[] _array;
        private int _count;
        public T Value { get; set; }

        public IEnumerator GetEnumerator() => _array.GetEnumerator();

        public DynamicArray()
        {
            _array = new T[1];
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

        public bool Equals(DynamicArray<T> other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return EqualityComparer<T>.Default.Equals(Value, other.Value);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(DynamicArray<T>)) return false;

            return Equals((DynamicArray<T>)obj);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<T>.Default.GetHashCode(Value);
        }
    }
}
