// See https://aka.ms/new-console-template for more information

using Tag3_05Command.command;
CommandHistory history = new CommandHistory();
string zeile;

while (true)
{
    Console.Write("#>");
    zeile = Console.ReadLine();
    
    if(zeile == "ende") break;
    if(zeile == "undo")
    {
        history.Undo();
        continue;
    }
    if(zeile == "redo")
    {
        history.Redo();
        continue;
    }

    
    Command command = CommandFactory.create(zeile);
    if(command == null) continue;
    command.Execute();
    history.Add(command);
    
}