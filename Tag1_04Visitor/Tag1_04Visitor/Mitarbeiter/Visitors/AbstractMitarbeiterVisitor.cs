using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag1_04Visitor.Mitarbeiter.Visitors
{
    internal abstract class AbstractMitarbeiterVisitor : MitarbeiterVisitor
    {
        public virtual void visit(LohnEmpfaenger lohnEmpfaenger)
        {
            // Ok
        }

        public virtual void visit(GehaltsEmpfaenger gehaltsEmpfaenger)
        {
           // NOP
        }
    }
}
