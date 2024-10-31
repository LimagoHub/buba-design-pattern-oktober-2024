using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tag2_02Composite.Konten.Visitors;

namespace Tag2_02Composite.Baum
{
    internal class Konto: AbstractKontoNode
    {

        public double Saldo { get; set; }
        public Konto(string label, double saldo = 0) : base(label)
        {
            Saldo = saldo;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Saldo)}: {Saldo}";
        }

        public override void accept(IKontenVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}
