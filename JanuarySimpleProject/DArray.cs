using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject
{
    internal class DArray
    {
        private string[] _array;
        private int _count;

        public DArray(int len)
        {
            _array = new string[len + len / 2];
            _count = 0;
        }

        private void ArrSize()
        {
            string[] item = new string[_array.Length * 2];
            if (_count == 0)
            {
            }
            for (int i = 0; i < _array.Length; i++)
            {
                item[i] = _array[i];
            }
            _array = item;
        }

        public void Add(string s)
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
                Console.WriteLine(s);
        }

        public void Remove(int s)
        {
            if (_count == 0)
            {
                throw new Exception("массив не имеет значений");
            }
        }

        public bool Contains(string s)
        {
            return Array.IndexOf(_array, s) != -1;
        }

        public int Count()
        {
            return _count;
        }


    }

}
