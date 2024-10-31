namespace Tag3_05Command.command;

public class CommandFactory
{
    public static Command create(string zeile)
    {
        Command result = null;
        String [] tokens = zeile.Split(' ');
        if (tokens[0] == "Add")
        {
            result = new AddCommand();
            result.Parse(tokens);
        }
        if (tokens[0] == "Print")
        {
            result = new PrintCommand();
            result.Parse(tokens);
        }


        return result;
    }
}