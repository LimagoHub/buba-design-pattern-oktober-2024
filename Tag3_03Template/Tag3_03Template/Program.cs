using Tag3_03Template.processor;

namespace Tag3_03Template;

class Program
{
    static void Main(string[] args)
    {
        AbstractFileProcessor abstractFileProcessor = new CharacterCounter();
        abstractFileProcessor.Run("c:\\tmp\\baerchen.txt");
    }
}