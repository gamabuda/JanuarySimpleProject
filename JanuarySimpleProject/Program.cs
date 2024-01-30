using JanuarySimpleProject.Core;
Console.OutputEncoding = System.Text.Encoding.UTF8;

//Node node = Node.CreateEmptyNode();
//node.Value = "Str";
//node.ShowInfo();

//node.ShowInfo();

//node.AddValue(Node.CreateEmptyNode());
//node.ShowInfo();

//List<int> ints = new List<int>()
//{
//    1, 2, 3
//};
//node.AddValue(ints);
//node.ShowInfo();

//Console.WriteLine(node.JSON);

//Console.ReadKey();

//SpecialNode specialNode = new SpecialNode("Special Node");
//specialNode.ShowInfo();


SpecialNode specialNode = new SpecialNode("Bank Node");
specialNode.Value = "Money";
specialNode.ShowInfo();
Console.WriteLine();
specialNode.Transaction(1000);
specialNode.ShowInfo();

DynamicArray<string> dynamicArray = new DynamicArray<string>(10);

dynamicArray.Add("Gold");
dynamicArray.Add("Silver");
dynamicArray.Add("Platinum");
dynamicArray.Add("Bronze");

dynamicArray.SortAuto();
string metals = dynamicArray.Print();
Console.WriteLine("\nMetals: " + metals);

Console.WriteLine("\nIndex of Silver: " + dynamicArray.BinarySearch("Silver"));
Console.WriteLine("Index of Gold: " + dynamicArray.BinarySearch("Gold"));
Console.WriteLine("Index of Bronze: " + dynamicArray.BinarySearch("Bronze"));
Console.WriteLine("Index of Platinum: " + dynamicArray.BinarySearchAuto("Platinum"));