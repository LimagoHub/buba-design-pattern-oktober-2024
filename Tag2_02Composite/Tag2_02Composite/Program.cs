using Tag2_02Composite.Baum;

namespace Tag2_02Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {

            KontoGruppe root = new KontoGruppe("Root");

            KontoGruppe e1_1 = new KontoGruppe("E1_1");
            root.AddChild(e1_1);

            KontoGruppe e1_2 = new KontoGruppe("E1_2");
            root.AddChild(e1_2);


            KontoGruppe e1_1_1 = new KontoGruppe("e1_1_1");
            e1_1.AddChild(e1_1_1);

            Konto e1_1_2 = new Konto("e1_1_2");
            e1_1.AddChild(e1_1_2);

            KontoGruppe e1_2_1 = new KontoGruppe("e1_2_1");
            e1_2.AddChild(e1_2_1);

            Konto e1_2_2 = new Konto("e1_2_2");
            e1_2.AddChild(e1_2_2);

            //travers(root);
            
            //root.Print();
            //e_1_1.Print();

            foreach (var node in root)
            {
                Console.WriteLine(node);
            }
            
        }

        static void travers(AbstractKontoNode abstractNode)
        {
            Console.WriteLine(abstractNode);
            foreach (var child in abstractNode.Children)
            {
                travers(child);
            }
        }
    }
}
