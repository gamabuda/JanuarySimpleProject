using JanuarySimpleProject.Core;
using JanuarySimpleProject.Core.Implementation;

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

//Node node = Node.CreateEmptyNode();
//node.ShowInfo();

//node.Value = "Str";
//node.ShowInfo();

//node.AddValue(Node.CreateEmptyNode());
//node.ShowInfo();

//List<int> ints = new List<int>()
//{
//    1, 2, 3
//};
//node.AddValue(ints);
//node.ShowInfo();

//node.RemoveValue("Str");
//node.ShowInfo();

//Console.WriteLine(node.JSON);


//Console.ReadKey();
DynamicArray<int> dynamicArray = new DynamicArray<int>();
dynamicArray.Add(5);
dynamicArray.Add(3);
dynamicArray.Add(9);
dynamicArray.Add(1);
Console.WriteLine("Массив перед сортировкой::");
dynamicArray.PrintArray();

dynamicArray.InsertionSort();

Console.WriteLine("Массив после сортировкой::");
dynamicArray.PrintArray();
Console.WriteLine("==================================================================================================================");

MyClass<int> m = new MyClass<int>();
m.Value = 1;
Console.WriteLine(m.Equals(1));
Console.ReadKey();