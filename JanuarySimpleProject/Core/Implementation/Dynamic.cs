
using System.Drawing;
using System;

namespace JanuarySimpleProject.Core.Implementation
{

    public class DynamicArray<TAnswer> where TAnswer : IComparable<TAnswer>
    {
        public TAnswer[] _values;
        private int count;
        public TAnswer Value { get; set; }
        public int Count { get { return count; } }

        public DynamicArray()
        {
            _values = new TAnswer[0];
        }

        public DynamicArray(TAnswer value)
        {
            _values = new TAnswer[1] { value };
        }

        public TAnswer this[int index]
        {
            get { return _values[index]; }
            set { _values[index] = value; }
        }

        public void Remove(TAnswer value)
        {
            int index = Array.IndexOf(_values, value);
            if (index != -1)
            {
                _values[index] = default(TAnswer);
                _values = _values.Where(a => a != null).ToArray();
            }
            else
            {
                throw new Exception("there is no such element in the array");
            }
        }

        public bool Contains(TAnswer value)
        {
            return _values.Contains(value);
        }

        public void Clear()
        {
            _values = new TAnswer[0];
        }

        public void Replace(TAnswer vValue, TAnswer newValue)
        {
            int index = Array.IndexOf(_values, vValue);
            _values[index] = newValue;
        }

        public IEnumerator<object> GetEnumerator()
        {
            for (int i = 0; i < _values.Length; i++)
            {
                yield return _values[i];
            }
        }

        private void IncreaseArray()
        {
            int newCount = count + count / 2;
            if (count == 0)
            {
                newCount = 10;
            }

            var newArray = new TAnswer[newCount];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = _values[i];
            }

            _values = newArray;
        }

        internal void Add(TAnswer item)
        {
            if (count == _values.Length)
            {
                IncreaseArray();
            }

            _values[count] = item;
            count++;
        }

        public int BinarySearch(TAnswer value)
        {
            return Array.BinarySearch(_values, 0, _values.Length, value);
        }

        public void Sort()
        {

            TAnswer[] array = new TAnswer[count];

            for (int i = 0; i < count; i++)
            {
                if (_values[i] != null)
                {
                    array[i] = _values[i];
                }
            }

            _values = array;

            Array.Sort(_values);
        }

    }
}