using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tag2_02Composite.Baum;

namespace Tag2_02Composite.Konten.Visitors
{

    // see Visitor Pattern
    internal class WeltspartagVisitor: AbstractKontenVisitor
    {
        public override void visit(Konto konto)
        {
            konto.Saldo += 5;
        }
    }
}
