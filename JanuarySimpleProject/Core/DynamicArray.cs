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

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
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
        public void Remove(T value)
        {
            int index = Array.IndexOf(array, value);

            if (index == -1)
                throw new ArgumentOutOfRangeException();

            RemoveAt(index);
        }

        public void RemoveAt(int index)
        {
            if (index <= 0 || array[index] == null)
                throw new ArgumentOutOfRangeException();           

            array[index] = default;
            Array.Copy(array, index + 1, array, index, count - index - 1);
            count--;
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
            foreach (T item in array)
            {
                if(item != null)
                    Console.WriteLine(item);
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
