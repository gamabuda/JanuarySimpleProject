using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject
{
    internal class DArray<T> where T: IComparable<T>
    {
        private T[] _array;
        private int _count;

        public DArray(int len)
        {
            _array = new T[len];
            _count = 0;
        }

        private void ArrSize()
        {
            int _count1 = _count + _count / 2;
            T[] item = new T[_count1];
            if (_count == 0)
            {
                _count1 = 20;
            }
            for (int i = 0; i < _array.Length; i++)
            {
                item[i] = _array[i];
            }
            _array = item;
        }

        public void Add(T s)
        {
            if (_count == _array.Length)
            {
                ArrSize();
            }
            _array[_count] = s;
            _count++;
        }

        public void Print()
        {
            foreach (var s in _array)
            {
                if (s != null)
                    Console.WriteLine(s);
            }
        }

        public void Remove(T s)
        {
            int index = -1;
            for (int i = 0; i < _count; i++)
            {
                if (_array[i].Equals(s))
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                for (int i = index; i < _count - 1; i++)
                {
                    _array[i] = _array[i + 1];
                }
                _count--;
            }
        }

        public bool Contains(T s)
        {
            if (_array.Contains(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Clear()
        {
            var Arr = new T[15];
            _array = Arr;
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

        public int BinarySearch(T s)
        {
            int left = 0;
            int right = _count - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (CompareTo(s) == 0)
                {
                    return mid;
                }
                else if (CompareTo(s) < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }

        private int CompareTo(T? s)
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            for (int i = 0; i < _count - 1; i++)
            {
                for (int j = i + 1; j < _count; j++)
                {
                    if (CompareTo(_array[j]) > 0)
                    {
                        T temp = _array[i];
                        _array[i] = _array[j];
                        _array[j] = temp;
                    }
                }
            }
        }

        internal void Insert(int index, string item)
        {
            throw new NotImplementedException();
        }

        internal void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

    }


}