using Tag2_02Composite.Baum;
using Tag2_02Composite.Konten.Visitors;

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

            Konto e1_1_2 = new Konto("e1_1_2", 1000);
            e1_1.AddChild(e1_1_2);

            KontoGruppe e1_2_1 = new KontoGruppe("e1_2_1");
            e1_2.AddChild(e1_2_1);

            Konto e1_2_2 = new Konto("e1_2_2", 100);
            e1_2.AddChild(e1_2_2);

            Konto e1_2_3 = new Konto("e1_2_3", 10);
            e1_2.AddChild(e1_2_3);

            //travers(root);

            //root.Print();
            //e_1_1.Print();

            //foreach (var node in root)
            //{
            //    Console.WriteLine(node);
            //}
            e1_2.iterate(new KontogruppenSaldoVisitor());
            root.iterate(new PrintVisitor());
            Console.WriteLine("-----------------------");

            root.iterate(new ZinsenVisitor(1.05));
            root.iterate(new PrintVisitor());

            Console.WriteLine("-----------------------");
            root.iterate(new WeltspartagVisitor());
            root.iterate(new PrintVisitor());

            Console.WriteLine("-----------------------");
           
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
