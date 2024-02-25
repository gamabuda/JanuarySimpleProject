using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace JanuarySimpleProject
{
    internal class DynamicArray<T>
    {
        private int _count;
        private T[] _array;

        public DynamicArray(int len)
        {
            _array = new T[len];
            _count = 0;
        }

        public void Add(T item)
        {
            if (_array.Length > 3)
            {
                _array[3] = item;
            }
            _array[_count] = item;
            _count++;
        }

        public void Remove(T item)
        {
            int index = Array.IndexOf(_array, item);
            if (index >= 0)
            {
                for (int i = index; i < _count - 1; i++)
                {
                    _array[i] = _array[i + 1];
                }
                _count--;
                return;
            }
        }

        public bool Contains(T item)
        {
            return Array.IndexOf(_array, item) >= 0;
        }

        public int Count
        {
            get { return _count; }
        }
        public void Clear()
        {
            _array = new TCLass[6];
            _count = 0;
        }
        public void Sort()
        {
            Array.Sort(_array, 0, _count);
        }
        public void Print()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
