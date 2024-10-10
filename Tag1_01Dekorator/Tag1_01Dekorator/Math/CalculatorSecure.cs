using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag1_01Dekorator.Math;

public class CalculatorSecure : ICalculator
{
    private readonly ICalculator _calculator;

    public CalculatorSecure(ICalculator calculator)
    {
        _calculator = calculator;
    }

    public virtual double Add(double a, double b)
    {
        Console.WriteLine("Du kommst hier rein");
        return _calculator.Add(a, b);
    }

    public virtual double Sub(double a, double b)
    {
        return _calculator.Sub(a, b);
    }
}
