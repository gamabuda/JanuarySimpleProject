using System;

namespace JanuarySimpleProject
{
    class DynamicArray<T>
    {
        private int count;
        private T[] array;
        private int length;

        public DynamicArray(int _len)
        {
            length = _len;
            array = new T[length];
            count = 0;
        }

        public void Add(T msg)
        {
            array[count] = msg;
            count++;

            if(count == array.Length)
            {
                T[] temp = new T[array.Length + 1];
                Array.Copy(array, temp, array.Length);
                array = temp;
            }
        }
        public void Remove(int index) 
        {
            array[index] = default;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if(i >= index + 1)
                {
                    array[i - 1] = array[i];
                }
            }
        }

        public void Remove(T value)
        {
            if (!array.Contains(value))
                throw new IndexOutOfRangeException();

            int index = IndexOf(value);

            array[index] = default;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i >= index + 1)
                {
                    array[i - 1] = array[i];
                }
            }
        }

        public void Clear()
        {
            array = new T[length];
        }

        public void Replace(T oldValue, T newValue)
        {
            int index = IndexOf(oldValue);
            array[index] = newValue;
        }

        public bool Contains(T msg) 
        { 
            return array.Contains(msg);
        }

        public int IndexOf(T msg) 
        {
            return Array.IndexOf(array, msg);
        }

        public void Print()
        {
            foreach (T s in array)
            {
                Console.WriteLine(s);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }
    }
}
