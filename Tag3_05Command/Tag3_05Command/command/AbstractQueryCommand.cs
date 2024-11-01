namespace Tag3_05Command.command;

public abstract class AbstractQueryCommand: Command
{
    public virtual void Parse(string[] tokens)
    {
        // NOP
    }

    public abstract void Execute();

    public virtual void Undo()
    {
        throw new InvalidOperationException("Undo nicht möglich.");
    }

    public virtual bool IsQuery()
    {
        return true;
    }
}