using Tag3_05Command.math;

namespace Tag3_05Command.command;

public class ClearCommand: AbstractCommand
{
    private double oldValue=0;
    

    public override void Execute()
    {
        oldValue = Calculator.Instance.Memory;
        Calculator.Instance.Clear();
    }

    public override void Undo()
    {
        Calculator.Instance.Memory = oldValue;
    }

    public override bool IsQuery()
    {
        return false;
    }
}