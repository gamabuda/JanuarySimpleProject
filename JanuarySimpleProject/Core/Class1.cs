using System.Drawing;
using System;

namespace JanuarySimpleProject.Core
{
    class DinamicArray<TCLass>
    {
        public TCLass[] _array;
        private int _count;

        public DinamicArray()
        {
            _array = new TCLass[10];
            _count = 0;
        }

        public void Add(TCLass zn)
        {
            if (_count == _array.Length)
            {
                TCLass[] temp = new TCLass[_array.Length * 2];
                for(int i = 0; i < _array.Length; i++)
                {
                    temp[i] = _array[i];
                }
                _array = temp;
            }
            _array[_count] = zn;
            _count++;
        }

        public void Remove(TCLass zn)
        {
            int index = Array.IndexOf(_array, zn, 0, _count);

            if (index != -1)
            {
                for (int i = 0; i < _count - 1; i++)
                {
                    _array[i] = _array[i + 1];
                }
                _array[_count-1] = default(TCLass);
                _count--;
            }
        }

        public bool Contains(TCLass zn)
        {
            return Array.IndexOf(_array, zn, 0, _count) != -1;
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

        public void Clear()
        {
            _array = new TCLass[4];
            _count = 0;
        }
        public void Sort()
        {
            Array.Sort(_array, 0, _count);
        }

        public int BinarySearch(TCLass item)
        {
            return Array.BinarySearch(_array, 0, _count, item);
        }
    }
}
