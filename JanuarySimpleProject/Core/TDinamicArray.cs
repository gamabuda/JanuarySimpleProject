using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core
{
    internal class TDinamicArray<TValue> : where TValue : IComparable<TValue>
    {

        private TValue[] _array;
        private int _count;
        public TDinamicArray(int len)
        {
            _array = new TValue[len + len];
            _count = 0;
        }
        public void Add(TValue s)
        {
            if (_count == _array.Length)
            {
                TValue[] newarray = new TValue[_count * 2];

                for (int i = 0; i < _count; i++)
                {
                    _array[i] = newarray[i];
                }
                _array = newarray;
            }
            _array[_count] = s;
            _count++;
        }
        public void Remove(TValue s)
        {
            int index = Array.IndexOf(_array, s, 0, _count);
            if (index != -1)
            {
                for (int i = 0; i < _count - 1; i++)
                {
                    _array[i] = _array[i + 1];
                }
            }

            _count--;
        }
        public void Clear()
        {
            _array = new TValue[0];
        }

        public int Count
        {
            get { return _count; }
        }
        public bool Contains(TValue s)
        {
            return Array.IndexOf(_array, s, 0, _count) != -1;
        }

        public void Print()
        {

            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_array[i] + " ");
            }
        }
        public IEnumerator<object> GetEnumerator()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                yield return _array[i];
            }
        }

        public void ReplaceX(TValue oldValue, TValue newValue)
        {
            int index = Array.IndexOf(_array, oldValue);
            _array[index] = newValue;
        }

        public void SortX(TValue array)
        {
            var N = _array.Length;
            while (N > 0)
            {
                for (int i = 0; i < N; i++)
                {
                      if (_array[i].CompareTo(_array[i+1])>0)
                      {
                        TValue temp = _array[i + 1];
                        _array[i + 1] = _array[i];
                        _array[i] = temp;

                      } 
                }
            }
        }
        public void BinarySearchX(TValue[] array)
        {
            var N = _array.Length;
            while (N > 0)
            {

            }
        }
    }                     

}
 
