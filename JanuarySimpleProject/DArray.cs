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
            _array = new string[len];
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

        public void Remove(string s)
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

        public bool Contains(string s)
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
            List<string> newItems = _array.ToList();
            newItems.Clear();
            _array = newItems.ToArray();
            _count = 0;
        }

        public string[] GetArray()
        {
            return _array;
        }

        public int Count()
        {
            return _count;
        }


    }

}
