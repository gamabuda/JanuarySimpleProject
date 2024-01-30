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
Console.WriteLine();
specialNode.ShowInfo();

specialNode.AddValue("Gold");
specialNode.AddValue("Silver");
specialNode.AddValue("Platinum");
specialNode.AddValue("Bronze");

specialNode.Sort();
string metals = specialNode.PrintArray();
Console.WriteLine("\tMetals in the Bank: " + metals);

Console.WriteLine("\n\tIndex of Silver: " + specialNode.BinarySearch("Silver"));
Console.WriteLine("\tIndex of Gold: " + specialNode.BinarySearch("Gold"));
Console.WriteLine("\tIndex of Bronze: " + specialNode.BinarySearch("Bronze"));
Console.WriteLine("\tIndex of Platinum: " + specialNode.BinarySearch("Platinum"));