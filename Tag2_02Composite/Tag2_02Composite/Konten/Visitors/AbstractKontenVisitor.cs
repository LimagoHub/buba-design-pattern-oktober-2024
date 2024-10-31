using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tag2_02Composite.Baum;

namespace Tag2_02Composite.Konten.Visitors
{
    internal abstract class AbstractKontenVisitor: IKontenVisitor
    {
        public virtual void init()
        {
            // pass
        }

        public virtual void visit(KontoGruppe kontoGruppe)
        {
            // pass
        }

        public virtual void visit(Konto konto)
        {
            // pass
        }

        public virtual void dispose()
        {
            // pass
        }
    }
}
