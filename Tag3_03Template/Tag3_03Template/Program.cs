using Tag3_03Template.processor;

namespace Tag3_03Template;

class Program
{
    static void Main(string[] args)
    {
        new FileProcessor()
         .AddFileHandler(new CharacterCounter())
         .AddFileHandler(new LineCounter())
         .Run("c:\\tmp\\baerchen.txt");
    }
}