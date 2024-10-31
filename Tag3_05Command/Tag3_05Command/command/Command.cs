namespace Tag3_05Command.command;

public interface Command
{
    void Parse(string [] tokens);
    void Execute();
    void Undo();
    bool IsQuery();
}