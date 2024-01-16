using System;

namespace JanuarySimpleProject
{
    class DynamicArray<T>
    {
        private static int count;
        private T[] array;

        public DynamicArray(int len)
        {
            array = new T[len];
            count = 0;
        }

        public void Add(T msg)
        {
            array[count] = msg;
            count++;

            if(count == array.Length - 1)
            {
                T[] temp = new T[array.Length + 10];

                for (int i = 0; i < array.Length; i++)
                {
                    temp[i] = array[i];
                }

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
                throw new Exception("There is no such value");

            int index = IndexOf(value);

            array[index] = default;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i >= index + 1)
                {
                    array[i - 1] = array[i];
                }
            
        }

        public void Clear()
        {
            array = new T[0];
        }

        public void Replace(T oldValue, T newValue)
        {
            int index = Array.IndexOf(array, oldValue);
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

        public IEnumerator<object> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }
    }
}
