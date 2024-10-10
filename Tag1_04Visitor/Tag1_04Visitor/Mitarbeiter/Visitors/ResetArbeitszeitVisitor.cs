using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag1_04Visitor.Mitarbeiter.Visitors
{
    internal class ResetArbeitszeitVisitor : AbstractMitarbeiterVisitor
    {
        public override void visit(LohnEmpfaenger lohnEmpfaenger)
        {
            lohnEmpfaenger.Arbeitszeit = 0;
        }

    }
}
