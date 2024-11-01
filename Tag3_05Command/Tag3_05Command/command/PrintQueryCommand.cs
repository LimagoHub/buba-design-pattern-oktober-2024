using Tag3_05Command.math;

namespace Tag3_05Command.command;

public class PrintQueryCommand: AbstractQueryCommand
{
    public override void Execute()
    {
        Calculator.Instance.Print();
    }
}