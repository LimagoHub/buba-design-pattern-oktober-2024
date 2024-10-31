using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tag2_02Composite.Baum;

namespace Tag2_02Composite.Konten.Visitors
{
    internal class KontogruppenSaldoVisitor: AbstractKontenVisitor
    {

        public double Saldo { get; private set; }
        public override void init()
        {
            Saldo = 0;
        }

        public override void visit(Konto konto)
        {
            Saldo += konto.Saldo;
        }

        public override void dispose()
        {
            Console.WriteLine(Saldo);
        }
    }
}
