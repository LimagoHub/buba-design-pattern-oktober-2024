using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag1_04Visitor.Mitarbeiter.Visitors
{
    internal class PrintVisitor : MitarbeiterVisitor
    {
        public void visit(LohnEmpfaenger lohnEmpfaenger)
        {
            Console.WriteLine(lohnEmpfaenger);        }

        public void visit(GehaltsEmpfaenger gehaltsEmpfaenger)
        {
            Console.WriteLine(gehaltsEmpfaenger);
        }
    }
}
