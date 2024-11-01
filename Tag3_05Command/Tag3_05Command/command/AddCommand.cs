using Tag3_05Command.math;

namespace Tag3_05Command.command;

public class AddCommand: AbstractCommand
{
    private double value=0;
    public override void Parse(string[] tokens)
    {
        value = double.Parse(tokens[1]);
    }

    protected override void ExecuteImpl()
    {
        Calculator.Instance.Add(value);
    }
}