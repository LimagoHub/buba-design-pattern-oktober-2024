using System.Reflection;

namespace Tag3_05Command.command;

public class CommandFactory
{
    private const string PREFIX = "Tag3_05Command.command.";
    private const string SUFFIX = "Command";

    public static Command create(string zeile)
    {
        try
        {
            String[] tokens = zeile.Split(' ');
            Assembly currentAssem = Assembly.GetExecutingAssembly();
            Command? result = currentAssem
                .GetType(PREFIX + tokens[0] + SUFFIX)
                .GetConstructor(new Type[] { })
                .Invoke(new object[] { }) as Command;
            
            result?.Parse(tokens);

            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }
}