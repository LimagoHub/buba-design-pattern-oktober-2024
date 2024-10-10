using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tag1_04Visitor.Mitarbeiter.Visitors;

namespace Tag1_04Visitor.Mitarbeiter
{
    internal class LohnEmpfaenger : AbstractMitarbeiter
    {
        public double Stundenlohn { get; set; } = 0;
        public double Arbeitszeit { get; set; } = 0;
        public LohnEmpfaenger(string name, double stundenlohn = 0, double arbeitszeit = 0) : base(name)
        {
            Stundenlohn = stundenlohn;
            Arbeitszeit = arbeitszeit;
        }

        public override string ToString()
        {
            return base.ToString() + ", Stundenlohn=" + Stundenlohn + ", Arbeitszeit=" + Arbeitszeit;
        }

        public override void accept(MitarbeiterVisitor visitor)
        {
            visitor.visit(this /* tis ist hier Lohnempfaeneger*/);
        }

    }
}
