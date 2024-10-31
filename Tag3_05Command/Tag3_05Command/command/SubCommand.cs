using Tag3_05Command.math;

namespace Tag3_05Command.command;

public class SubCommand: Command
{
    private double value=0;
    public void Parse(string[] tokens)
    {
        value = double.Parse(tokens[1]);
    }

    public void Execute()
    {
        Calculator.Instance.Sub(value);
    }

    public void Undo()
    {
        Calculator.Instance.Add(value);
    }

    public bool IsQuery()
    {
        return false;
    }
}