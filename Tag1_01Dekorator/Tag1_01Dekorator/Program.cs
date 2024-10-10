// See https://aka.ms/new-console-template for more information


using Buba.Client;

using System;
using Tag1_01Dekorator.Math;

ICalculator calculator = new Calculator();// 1000
calculator /* 2000 */  = new CalculatorLogger(/* 1000 */ calculator);
calculator /* 3000 */  = new CalculatorSecure(/* 2000 */ calculator);
CalcClient calcClient = new CalcClient(/* 3000 */calculator);
calcClient.Run();

DateTime start = DateTime.Now;

DateTime end = DateTime.Now;

TimeSpan duration = end - start;

Console.WriteLine(duration.Milliseconds);

