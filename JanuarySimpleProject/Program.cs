﻿using JanuarySimpleProject;
using JanuarySimpleProject.Core;
using System;

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

internal class Program
{
    private static void Main(string[] args)
    {
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
        DArray<string> dArray = new DArray<string>(10);
        dArray.Add("gdsyug");
        dArray.Add("bsdfsb");
        dArray.Add("skafguyg");
        dArray.Print();
        dArray.Sort();
        dArray.Print();
        Console.WriteLine(dArray.BinarySearch("skafguyg"));
        

        Console.WriteLine(node.JSON);


        Console.ReadKey();
    }
}