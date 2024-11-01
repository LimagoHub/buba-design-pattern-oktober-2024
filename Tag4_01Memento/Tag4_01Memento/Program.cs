// See https://aka.ms/new-console-template for more information

using Tag4_01Memento.tier;

Schwein piggy = new Schwein("Miss Piggy");

Console.WriteLine(piggy);
SchweineMemento memento = piggy.GetMemento();

piggy.fuettern();

Console.WriteLine(piggy);
piggy.SetMemento(memento);
Console.WriteLine(piggy);