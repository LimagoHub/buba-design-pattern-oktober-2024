using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag1_01Dekorator.Math
{
    public class CalculatorLogger : ICalculator
    {

        private readonly ICalculator calculator;

        public CalculatorLogger(ICalculator calculator)
        {
            this.calculator = calculator;
        }
        public virtual double Add(double a, double b)
        {
            Console.WriteLine("Add wurde gerufen");
            return calculator.Add(a, b);
        }

        public virtual double Sub(double a, double b)
        {
            return calculator.Sub(a, b);
        }
    }
}
