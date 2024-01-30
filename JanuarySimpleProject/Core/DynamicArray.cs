using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JanuarySimpleProject.Core.Implementation;

namespace JanuarySimpleProject.Core
{
    internal class DynamicArray<T>
    {
        private string[] _array;
        private int _count;

        public DynamicArray()
        {
            _array = new string[4];
            _count = 0;
        }

        public void Add(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (_count == _array.Length)
            {
                int newLength = _array.Length * 2;
                Array.Resize(ref _array, newLength);
            }

            _array[_count] = str;
            _count++;
        }

        public void Remove(string str)
        {
            int index = Array.IndexOf(_array, str, 0, _count);

            if(index != -1)
            {
                for(int i = 0; i < _count - 1; i++)
                {
                    _array[i] = _array[i + 1];
                }
                _count--;
            }
        }

        private int BinarySearch(string[] array, int left, int right, string value)
        {
            while (left <= right)
            {   
                int mid = left + (right - left) / 2;

                int compareResult = string.Compare(array[mid], value);

                if (compareResult == 0)
                {
                    return mid;
                }
                else if (compareResult < 0)
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

        public bool Contains(string str)
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

        public int Count
        {
            get { return _count; }
        }

        private int CustomCompare(T obj1, T obj2)
        {
            int hashCode1 = obj1.GetHashCode();
            int hashCode2 = obj2.GetHashCode();

            return hashCode1.CompareTo(hashCode2);
        }

        public void CustomSort()
        {
            Array.Sort(_array, 0, _count, StringComparer.Create(new CultureInfo("en-US"), false));
        }
    }
}
