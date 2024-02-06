using System;

public class DynamicArray<T> where T : IComparable<T>
{
    private T[] array;
    private int count;

    public DynamicArray()
    {
        array = new T[4];
        count = 0;
    }

    public void Add(T item)
    {
        if (count == array.Length)
        {
            Array.Resize(ref array, array.Length * 2);
        }

        array[count] = item;
        count++;
    }

    public void Remove(T item)
    {
        int index = Array.IndexOf(array, item, 0, count);

        if (index != -1)
        {
            for (int i = index; i < count - 1; i++)
            {
                array[i] = array[i + 1];
            }

            count--;
        }
    }

    public bool Contains(T item)
    {
        return Array.IndexOf(array, item, 0, count) != -1;
    }

    public int Count
    {
        get { return count; }
    }

    public void Print()
    {
        Console.Write("Array elements: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    public void Sort()
    {
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = 0; j < count - i - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    public int BinarySearch(T item)
    {
        int left = 0;
        int right = count - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            int comparisonResult = item.CompareTo(array[mid]);

            if (comparisonResult == 0)
            {
                return mid;
            }
            else if (comparisonResult < 0)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return -1;
    }
}