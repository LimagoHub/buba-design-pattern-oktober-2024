using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag1_01Dekorator.Math
{
    public class Calculator : ICalculator
    {

        internal Calculator() { }

        public virtual double Add(double a, double b)
        {
            return a + b;
        }

        public virtual double Sub(double a, double b)
        {
            return Add(a, -b);
        }
    }
}
