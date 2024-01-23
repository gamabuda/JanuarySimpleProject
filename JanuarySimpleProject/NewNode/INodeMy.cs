using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.NewNode
{
    public interface INode
    {
        string Id { get; }
        string Name { get; set; }
        string Value { get; set; }
        DateTime DateTimeCreate { get; }
        DateTime DateTimeUpdate { get; }

        void ShowInfo();
        void AddValue<TValue>(TValue value);
        void RemoveValue<TValue>(TValue value);
        void UpdateValue<TValue>(TValue oldValue, TValue newValue);
        event Action OnNodeChange;
    }
}
