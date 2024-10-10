using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag1_01Dekorator.Math
{
    public class CalculatorFactory
    {
        public static bool Logger { get; set; } = false;
        public static bool Secure { get; set; } = false;

        public static ICalculator createInstance() { 
            ICalculator calcuctor = new Calculator();
            if(Logger) calcuctor = new CalculatorLogger(calcuctor);
            if(Secure) calcuctor = new CalculatorSecure(calcuctor);

            return calcuctor;
        }
    }
}
