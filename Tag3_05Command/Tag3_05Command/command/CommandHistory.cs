namespace Tag3_05Command.command;

public class CommandHistory
{
    
    private Stack<Command> undoStack = new Stack<Command>();
    private Stack<Command> redoStack = new Stack<Command>();
    public void Add(Command command)
    {
        if (command.IsQuery()) return;
        // ...
        redoStack.Clear();
    }

    public void Undo()
    {
        Console.WriteLine("Can't undo");
    }
    
    public void Redo()
    {
        Console.WriteLine("Can't redo");
    }
}