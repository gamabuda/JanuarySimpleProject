//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace JanuarySimpleProject.Core
//{
//    internal class DynamicArray
//    {
//        private string[] _array;
//        private int _count;

//        public DynamicArray()
//        {
//            _array = new string[4];
//            _count = 0;
//        }

//        public void Add(string str)
//        {
//            if (_count == _array.Length)
//            {
//                //TODO написать свой
//                Array.Resize(ref _array, _array.Length * 2);
//            }
//            _array[_count] = str;
//            _count++;
//        }

//        public void Remove(string str)
//        {
//            int index = Array.IndexOf(_array, str, 0, _count);

//            if(index != -1)
//            {
//                for(int i = 0; i < _count - 1; i++)
//                {
//                    _array[i] = _array[i + 1];
//                }
//                _count--;
//            }
//        }

//        public bool Contains(string str)
//        {
//            return Array.IndexOf(_array, str, 0, _count) != -1;
//        }

//        public void Print()
//        {
//            for (int i = 0; i < _count; i++)
//            {
//                Console.Write(_array[i] + " ");
//            }
//            Console.WriteLine();
//        }

//        public int Count
//        {
//            get { return _count; }
//        }
//    }
//}
