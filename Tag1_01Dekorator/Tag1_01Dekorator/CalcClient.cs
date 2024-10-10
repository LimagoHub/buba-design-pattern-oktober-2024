using System;
using Tag1_01Dekorator.Math;


namespace Buba.Client
{
    public class CalcClient
    {
        private readonly ICalculator calculator;

        public CalcClient(ICalculator calculator)
        {
            this.calculator = calculator;
        }

        public void Run()
        {
           

            Console.WriteLine(calculator.Add(3, 4));
        }
       
    }
}
