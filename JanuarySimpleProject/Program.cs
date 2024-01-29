using JanuarySimpleProject.Core;
using JanuarySimpleProject.Core.Implementation;
using System.Text.Json;

/*
 * Я накидал вам базы по прошлому полугодию, друзья!
 * Надеюсь пример получился не перегруженным, а даже если и так, то это к лучшему
 * Покопаетесь, вспомните, подучите то что пропустили
 * Deadline: 27.01.24
 * Задание: Необходимо закрыть все TODO-шки
 * 
 * P/s
 * Удобно просмотреть их можно во вкладке: Вид > Список задач
 * This message for my English-speaking friends: View > Tasks
 * 
 * Залил в main = не любишь маму
 * Тудушка с отпимизацией = плюс балл и респект (делать по желанию)
 * Одна тудушка = один коммит (в ином исходе будет засчитано половина от всех баллов)
 * Одна тудушка = 2 балла
 */

Node node = Node.CreateEmptyNode();
node.ShowInfo();

node.Value = "Str";
node.ShowInfo();

node.AddValue(Node.CreateEmptyNode());
node.ShowInfo();

List<int> ints = new List<int>()
{
    1, 2, 3
};
node.AddValue(ints);
node.ShowInfo();

node.RemoveValue("Str");
node.ShowInfo();

node.AddValue(111);
node.ShowInfo();

Console.WriteLine(node.UpdateValue(111, 222));
node.ShowInfo();

node.RemoveValue(ints);
node.ShowInfo();

node.Value = "Str";
node.ShowInfo();


Console.WriteLine("\t\tЧтобы посмотреть функционал моей ноды нажмите любую кнопку");
Console.ReadKey();
Console.Clear();

MyNode myNode = new("myNode");
myNode.Value = 12;

myNode.AddValue(12);

myNode.AddValue("MMM");
myNode.UpdateValue("MMM", "FDF");

myNode.RemoveValue("FDF");

myNode.RemoveAllValue(12);

Console.WriteLine("\t\tЧтобы посмотреть бинарный поиск, нажмите любую кнопку");
Console.ReadKey();
Console.Clear();

DynamicArray<MyClass<int>, int> array = new DynamicArray<MyClass<int>, int>();
array.Add(12);
array.Add(72);
array.Add(38);
array.Add(22);
array.Add(37);
array.Add(88);
array.Add(93);
array.Add(106);

Console.WriteLine("\t\tСортировка происходит по хешкоду\n");
Console.WriteLine("Не сортированный массив");
foreach (MyClass<int> item in array)
{
    Console.WriteLine(item.Value);
}

array.Sort();
Console.WriteLine("\nСортированный массив");
foreach (MyClass<int> item in array)
{
    Console.WriteLine(item.Value);
}

Console.WriteLine($"\nИндекс числа '12' в массиве: {array.BinnarySearch(12)}");
Console.WriteLine($"\nИндекс числа '22' в массиве: {array.BinnarySearch(22)}");
Console.WriteLine($"\nИндекс числа '433'(его нет в массиве) в массиве: {array.BinnarySearch(433)}");