using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tag2_02Composite.Baum;

namespace Tag2_02Composite.Konten.Visitors
{
    internal interface IKontenVisitor
    {
        void init();
        void visit(KontoGruppe kontoGruppe);
        void visit(Konto konto);
        void dispose();
    }
}
