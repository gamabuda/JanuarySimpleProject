using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core.Implementation
{
    public class DArray
    {
        private string[] _array;
        private int _count;
        public DArray(int len)
        {
            _array = new string[len + len / 2];
            _count = 0;
        }

        public void Add(string s)
        {
            if (_count == _array.Length)
            {
                Resize();
            }
            _array[_count] = s;
            _count++;
        }
        public void Remove(string s)
        {
            int index = Array.IndexOf(_array, s);
            if (index != -1)
            {
                for (int i = index; i < _count - 1; i++)
                {
                    _array[i] = _array[i + 1];
                }
                _count--;
            }
        }
        public bool Contains(string s)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_array[i] == s)
                {
                    return true;
                }
            }
            return false;
        }
        public int Count()
        {
            return _count;
        }
        
        public void Print()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_array[i]);
            }
        }
        public string[] GetArray()
        {
            string[] result = new string[_count];
            Array.Copy(_array, result, _count);
            return result;
        }
        private void Resize()
        {
            int newCount = _count + _count / 2;
            if (_count == 0)
            {
                newCount = 10;
            }

            var newArray = new string[newCount];
            for (int i = 0; i < _count; i++)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;
        }

        public int BinarySearch(string s)
        {
            int low = 0;
            int high = _count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int compareResult = String.Compare(_array[mid], s);

                if (compareResult == 0)
                {
                    return mid;
                }
                else if (compareResult < 0)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }
    }
}