using JanuarySimpleProject.Core;
using JanuarySimpleProject.Core.Implementation;
using System;

DArray node = new DArray(10);
node.Add("здоровье");
node.Add("сон");
node.Add("еда");

foreach (var item in node.GetArray())
{
    Console.Write(item + " ");
}
Console.WriteLine("\n" + node.BinarySearch("сон"));

Console.WriteLine("До сортировки:");
node.Print();
node.Sort();
Console.WriteLine("\n После сортировки:");
node.Print();