using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core
{
    public class DynamicArray
    {
        private int[] items;

        private int size;

        public DynamicArray(int length)
        {
            items = new int[length];
            size = 0;
        }

        public DynamicArray()
        {
            items = new int[0];
        }

        public string Print()
        {
            string result = "";
            for (int i = 0; i < size; i++)
            {
                result += items[i] + " ";
            }

            return result;
        }

        public int GetCount()
        {
            return size;
        }

        public int Get(int index)
        {
            if (index >= size || index < 0)
            {
                throw new Exception("Индекс находится за пределами массива.");
            }

            return items[index];
        }

        public int Find(int key)
        {
            for (int i = 0; i < size; i++)
            {
                if (items[i] == key)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
