using JanuarySimpleProject.Core;
using System.Formats.Asn1;

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

MoiaNode moiaNode = new MoiaNode();
moiaNode.AddValue("7sisa");
moiaNode.ShowInfo();
DinamicArray<string> dinamicArray = new DinamicArray<string>();
dinamicArray.Add("мяу мяу мяу");
dinamicArray.Add("миу миу миу");
dinamicArray.Add("мур мур мур");
dinamicArray.Add("мрр мрр мрр");
dinamicArray.Sort();
Console.WriteLine(dinamicArray.BinarySearch("миу миу миу"));