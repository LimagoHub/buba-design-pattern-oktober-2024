using Tag1_04Visitor.Mitarbeiter;
using Tag1_04Visitor.Mitarbeiter.Visitors;

namespace Tag1_04Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Firma.Firma firma = new Firma.Firma();
            firma.AddMitarbeiter(new GehaltsEmpfaenger("Hinz", 2000));
            firma.AddMitarbeiter(new LohnEmpfaenger("Schmitt", 20, 15));
            firma.AddMitarbeiter(new LohnEmpfaenger("Meyer", 10, 12));
            firma.AddMitarbeiter(new LohnEmpfaenger("Schulz", 20, 40));
            firma.AddMitarbeiter(new GehaltsEmpfaenger("Kunz", 2000));


            //firma.Print();
            firma.iterate(new PrintVisitor());
            firma.iterate(new ResetArbeitszeitVisitor());
            firma.iterate(new PrintVisitor());
        }
    }
}
