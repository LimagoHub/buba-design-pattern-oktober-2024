using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tag1_04Visitor.Mitarbeiter.Visitors;

namespace Tag1_04Visitor.Mitarbeiter
{
    internal class GehaltsEmpfaenger : AbstractMitarbeiter
    {

        public double Gehalt { get; set; } = 0;
        public GehaltsEmpfaenger(string name, double gehalt = 0) : base(name)
        {
            Gehalt = gehalt;
        }

        public override string ToString()
        {
            return base.ToString() + ", Gehalt = " + Gehalt;
        }

        public override void accept(MitarbeiterVisitor visitor)
        {
            visitor.visit(this /* tis ist hier Gehaltsempfaeneger*/);
        }
    }
}
