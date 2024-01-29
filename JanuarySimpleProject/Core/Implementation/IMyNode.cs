using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core.Implementation
{
    public interface IMyNode
    {
        string Id { get; }
        string Name { get; set; }
        object Value { get; set; }
        DateTime DateTimeCreate { get; }
        DateTime DateTimeUpdate { get; }

        void ShowInfo();
        void AddValue<TValue>(TValue value);
        void RemoveValue<TValue>(TValue value);
        //TODO write UpadateValue method (accomplished)
        TValue UpdateValue<TValue>(TValue oldValue, TValue newValue);
        event Action OnNodeChange;
    }
}