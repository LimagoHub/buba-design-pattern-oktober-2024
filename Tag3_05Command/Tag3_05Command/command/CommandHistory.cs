namespace Tag3_05Command.command;

public class CommandHistory
{
    
    private Stack<Command> undoStack = new Stack<Command>();
    private Stack<Command> redoStack = new Stack<Command>();
    public void Add(Command command)
    {
        if (command.IsQuery()) return;
        undoStack.Push(command);
        redoStack.Clear();
    }

    public void Undo()
    {
        if (! undoStack.Any())
        {
            Console.WriteLine("Can't undo");
            return;
        }
        var command = undoStack.Pop();
        command.Undo();
        redoStack.Push(command);
       
    }
    
    public void Redo()
    {
        if (! redoStack.Any())
        {
            Console.WriteLine("Can't redo");
            return;
        }
        var command = redoStack.Pop();
        command.Execute();
        undoStack.Push(command);
    }
}