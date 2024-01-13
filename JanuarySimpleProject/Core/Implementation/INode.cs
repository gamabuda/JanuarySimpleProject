using System;
namespace JanuarySimpleProject.Core.Implementation
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
        //TODO write UpadateValue method

        event Action OnNodeChange;
    }
}

