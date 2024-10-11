using Tag2_02Composite.Baum;

namespace Tag2_02Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Node root = new Node("Root");

            Node e1_1 = new Node("E1_1");
            root.AddChild(e1_1);

            Node e1_2 = new Node("E1_2");
            root.AddChild(e1_2);


            Node e1_1_1 = new Node("e1_1_1");
            e1_1.AddChild(e1_1_1);

            Leaf e1_1_2 = new Leaf("e1_1_2");
            e1_1.AddChild(e1_1_2);

            Node e1_2_1 = new Node("e1_2_1");
            e1_2.AddChild(e1_2_1);

            Leaf e1_2_2 = new Leaf("e1_2_2");
            e1_2.AddChild(e1_2_2);

            travers(root);
           
        }

        static void travers(AbstractNode abstractNode)
        {
            Console.WriteLine(abstractNode);
            foreach (var child in abstractNode.Children)
            {
                travers(child);
            }
        }
    }
}
