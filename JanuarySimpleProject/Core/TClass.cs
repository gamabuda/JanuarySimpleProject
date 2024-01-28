using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core
{
    internal class TClass<T>
    {
        private T _value;

        public TClass(T value)
        {
            _value = value;
        }
        public void ShowTType()
        {
            Console.WriteLine(_value.GetType());
        }
    }
}
