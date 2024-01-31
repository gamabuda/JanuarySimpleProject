using JanuarySimpleProject.Core;
using static JanuarySimpleProject.Core.Node;

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

TDinamicArray<int> t = new TDinamicArray<int>(5);
t.Add(2);
t.Add(1);
t.Add(5);
t.Add(4);
t.Add(3);
t.Print();
t.SortX(t.Count);
t.Print();


Console.ReadKey();