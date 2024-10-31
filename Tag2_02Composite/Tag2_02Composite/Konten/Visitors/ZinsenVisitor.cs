using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tag2_02Composite.Baum;

namespace Tag2_02Composite.Konten.Visitors
{
    internal class ZinsenVisitor: AbstractKontenVisitor
    {
        public double Zins { get; }
        public ZinsenVisitor(double zins)
        {
            Zins = zins;
        }

        public override void visit(Konto konto)
        {
            konto.Saldo *= Zins;
        }
    }
}
