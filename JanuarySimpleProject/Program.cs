using JanuarySimpleProject.Core;

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

Console.WriteLine(node.JSON);

Console.ReadKey();

SpecialNode specialNode = new SpecialNode("Special Node");
specialNode.ShowInfo();
