﻿public class DynamicArray<T>
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
}