
using System.Collections;

namespace JanuarySimpleProject.Core
{
    public class DynamicArray<T> : IEnumerable, IEquatable<DynamicArray<T>>
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

            if (count == array.Length)
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

        public void Sort()
        {
            if (typeof(T) == typeof(string))
            {
                BubbleSort(array, StringComparer.CurrentCulture as IComparer<T>);
            }
            else
            {
                BubbleSort(array, Comparer<T>.Default);
            }
        }

        private void BubbleSort(T[] arr, IComparer<T> comparer)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (comparer.Compare(arr[j], arr[j + 1]) > 0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        //бинарный поиск работает только после сортировки
        public int BinarySearch(T value)
        {
            if (!array.Any())
                return -1; 

            int left = 0;
            int right = count - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                int comparisonResult = Comparer<T>.Default.Compare(array[middle], value);

                if (comparisonResult == 0)
                {
                    return middle; 
                }
                else if (comparisonResult < 0)
                {
                    left = middle + 1; 
                }
                else
                {
                    right = middle - 1; 
                }
            }

            return -1;
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
                if (item != null)
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
        public T Value { get; set; }

        public bool Equals(DynamicArray<T> other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return EqualityComparer<T>.Default.Equals(Value, other.Value);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(DynamicArray<T>)) return false;

            return Equals((DynamicArray<T>)obj);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<T>.Default.GetHashCode(Value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }
    }
}
