using Tag3_05Command.math;

namespace Tag3_05Command.command;

public abstract class AbstractCommand: Command
{
    private ICalculatorMemento _memento;
    public abstract void Parse(string[] tokens);

    public void Execute()
    {
        _memento = Calculator.Instance.Memento;
        ExecuteImpl();
    }

    protected abstract void ExecuteImpl();

    public void Undo()
    {
        Calculator.Instance.Memento = _memento;
    }

    public bool IsQuery()
    {
        return false;
    }
}