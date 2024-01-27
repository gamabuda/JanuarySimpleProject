using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core.Implementation
{
    public class DynamicArray
    {
        private int[] array;
        private int count;

        public DynamicArray()
        {
            array = new int[4];
            count = 0;
        }

        public void Add(int item)
        {
            if (count == array.Length)
            {
                Array.Resize(ref array, array.Length * 2);
            }

            array[count] = item;
            count++;
        }

        public void Remove(int item)
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

        public bool Contains(int item)
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

