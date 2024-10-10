// See https://aka.ms/new-console-template for more information


using Buba.Client;

using System;
using Tag1_01Dekorator.Math;

CalculatorFactory.Logger = true;
CalculatorFactory.Secure = true;

ICalculator calculator = CalculatorFactory.createInstance();

CalcClient calcClient = new CalcClient(calculator);
calcClient.Run();



