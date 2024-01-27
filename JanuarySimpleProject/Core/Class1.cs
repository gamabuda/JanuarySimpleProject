namespace JanuarySimpleProject
{
    class DynamicArray<T>
    {
        private int count;
        private T[] array;

        public DynamicArray(int len)
        {
            array = new T[len];
            count = 0;
        }

        public void Add(T item)
        {
            if (count == array.Length)
            {
                T[] temp = new T[array.Length ]; // изменить
               
            }
            array[count] = item;
            count++;
        }

        public void Remove(T item)
        {
            int index = Array.IndexOf(array, item); 
            if (index >= 0)
            {
                for (int i = index; i < count - 1; i++)
                {
                    array[i] = array[i + 1]; 
                }
                count--;
                return;
            }
        }

        public  bool Contains(T item)
        {
            return Array.IndexOf(array, item) >= 0;
        }

        public int Count
        {
            get { return count; }
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
        }
    }
}

