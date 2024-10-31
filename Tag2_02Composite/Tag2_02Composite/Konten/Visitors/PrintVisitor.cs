using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tag2_02Composite.Baum;

namespace Tag2_02Composite.Konten.Visitors
{
    internal class PrintVisitor: AbstractKontenVisitor
    {
        public override void visit(KontoGruppe kontoGruppe)
        {
            Console.WriteLine(kontoGruppe);
        }

        public override void visit(Konto konto)
        {
            Console.WriteLine(konto);
        }
    }
}
