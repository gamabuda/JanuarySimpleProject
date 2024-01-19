using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core
{
    internal class TDinamicArray<TValue>
    {
        
            private TValue[] _array;
            private int _count;
            public TDinamicArray(int len)
            {
                _array = new TValue[len + len];
                _count = 0;
            }
            void Add(TValue s)
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
            void Remove(TValue s)
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

            public int Count
            {
                get { return _count; }
            }
            public bool Contains(TValue s)
            {
                return Array.IndexOf(_array, s, 0, _count) != -1;
            }

            void Print()
            {

                for (int i = 0; i < _count; i++)
                {
                    Console.WriteLine(_array[i] + " ");
                }
            }


        
    }
}
