using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core
{
    public class DynamicArray
    {
        private string[] _array;
        private int _count;

        public DynamicArray(object value)
        {
            _array = new string[1] { value.ToString() };
            _count = 0;
        }

        public void Add(string str)
        {
            int oldSize = _array.Length;
            string[] newArray = new string[oldSize + 10];

            for (int i = 0; i < _array.Length; i++) { newArray[i] = _array[i]; }

            _array = newArray;
            _array[_count] = str;
            _count++;
            
        }


        public void Remove(string str)
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

        public void Replace(string oldValue, string newValue)
        {
            int index = Array.IndexOf(_array, oldValue);
            _array[index] = newValue;
        }

        public int Count
        {
            get { return _count; }
        }

        public static implicit operator List<object>(DynamicArray v)
        {
            throw new NotImplementedException();
        }
    }
}
