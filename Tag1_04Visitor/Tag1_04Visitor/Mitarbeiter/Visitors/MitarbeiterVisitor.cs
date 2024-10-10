using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag1_04Visitor.Mitarbeiter.Visitors
{
    internal interface MitarbeiterVisitor
    {
        void visit(LohnEmpfaenger lohnEmpfaenger);
        void visit(GehaltsEmpfaenger gehaltsEmpfaenger);
    }
}
