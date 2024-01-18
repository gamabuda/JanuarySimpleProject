using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject
{
    internal class TClass<TValue>
    {
        private TValue _value;

        public TClass(TValue value)
        {
            _value = value;
        }
        public void ShowTType()
        {
            Console.WriteLine(_value.GetType());
        }
    }
}