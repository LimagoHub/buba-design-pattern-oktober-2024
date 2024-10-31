// See https://aka.ms/new-console-template for more information

using Tag3_05Command.command;

string zeile;

while (true)
{
    Console.Write("#>");
    zeile = Console.ReadLine();
    
    if(zeile == "ende") break;
    Command command = CommandFactory.create(zeile);
    if(command == null) continue;
    command.Execute();
    
}