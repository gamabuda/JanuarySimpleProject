
using System;

namespace JanuarySimpleProject
{
    public class DynamicArray<T> where T : IComparable<T>
    {
        private int _count;
        private T[] _items;
        public T Value { get; set; }
        public int Count { get { return _count; } }

        public DynamicArray(int len)
        {
            _items = new T[len];
            _count = 0;
        }

        public void Add(T item)
        {
            if (_items.Length > 3)
            {
                _items[3] = item;
            }
            _items[_count] = item;
            _count++;
        }

        public void Remove(T item)
        {
            int index = Array.IndexOf(_items, item, _count);
            if (_count == 0)
            {
                throw new Exception("Массив пуст");
            }

            if (index >= 0)
            {
                for (int i = index; i < _count - 1; i++)
                {
                    _items[i] = _items[i + 1];
                }
                _count--;
                if (_count == 0)
                {
                    throw new Exception("Массив пуст");
                }

            }
        }

        public bool Contains(T _item)
        {
            if (_items.Contains(_item))
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
            _items = new T[6];
            _count = 0;
        }
        public T[] Sort()
        {
            T[] array = new T[_count];

            for (int i = 0; i < _count; i++)
            {
                if (_items[i] != null)
                {
                    array[i] = _items[i];
                    _items = array;
                }
            }
            return array;
        }
        private void IncreaseArray()
        {
            int newCount = _count + _count / 2;
            if (_count == 0)
            {
                newCount = 10;
            }

            var newArray = new T[newCount];
            for (int i = 0; i < _count; i++)
            {
                newArray[i] = _items[i];
            }

            _items = newArray;
        }

        public void Print()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_items[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
