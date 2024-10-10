using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag1_01Dekorator.Math
{
    public class CalculatorFactory
    {

        public static ICalculator createInstance() { 
            return new Calculator(); 
        }
    }
}
