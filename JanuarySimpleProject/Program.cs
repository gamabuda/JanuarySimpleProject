
//using JanuarySimpleProject;
//using RTS.Core;
//using RTS.Core.Buildings;
//using System.Threading;

//var wizard = new Wizard();
//var rogue = new Rogue();
//var warrior = new Warrior();

//warrior.DealDamage(rogue);
//Console.WriteLine(rogue.HP);

//rogue.ShowInfo();
//Console.WriteLine(rogue.MaxHealth);

//var w = Barrack.CreateUnit("Wizzard");
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
//DynamicArray array = new DynamicArray();
//array.Add("sadas");
//array.Add("qwert");
//array.Add("zxc");
//array.Add("sadas");
//array.Add("qwert");
//array.Add("zxc");
//array.Print();

//TClass<Node> t1 = new TClass<Node>(Node.CreateEmptyNode());
//t1.ShowTType();
//TClass<int> t2 = new TClass<int>(12);
//t2.ShowTType();
//TClass<string> t3 = new TClass<string>("qwerty");
//t3.ShowTType();

//MyClass<int> m = new MyClass<int>();
//m.Value = 1;
//Console.WriteLine(m.Equals(1));

//Console.ReadKey();