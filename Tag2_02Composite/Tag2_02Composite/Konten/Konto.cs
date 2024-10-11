using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag2_02Composite.Baum
{
    internal class Konto: AbstractKontoNode
    {

        public double Saldo { get; set; }
        public Konto(string label) : base(label)
        {
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Saldo)}: {Saldo}";
        }
    }
}
