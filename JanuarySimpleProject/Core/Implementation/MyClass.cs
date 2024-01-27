using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core.Implementation
{
    public class MyClass <TValue> : IEnumerable,IEquatable<MyClass<TValue>>
    {
        public TValue Value { get; set; }
        private TValue[] Values { get; set; } = new TValue[10];

        public void Add(TValue value) => Values[0] = value;

        public IEnumerator<TValue> GetEnumerator()
        {
            return ((IEnumerable<TValue>)Values).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Values.GetEnumerator();
        }

        public bool Equals(MyClass<TValue> other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return EqualityComparer<TValue>.Default.Equals(Value, other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(MyClass<TValue>)) return false;

            return Equals((MyClass<TValue>)obj);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<TValue>.Default.GetHashCode(Value);
        }
    }
}
    
