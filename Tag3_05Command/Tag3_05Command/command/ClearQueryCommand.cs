using Tag3_05Command.math;

namespace Tag3_05Command.command;

public class ClearQueryCommand: AbstractQueryCommand
{
    private ICalculatorMemento calculatorMemento;
    

    public override void Execute()
    {
        calculatorMemento = Calculator.Instance.Memento;
        Calculator.Instance.Clear();
    }

    public override void Undo()
    {
        Calculator.Instance.Memento = calculatorMemento;
    }

    public override bool IsQuery()
    {
        return false;
    }
}