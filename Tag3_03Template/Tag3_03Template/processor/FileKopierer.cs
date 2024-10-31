namespace Tag3_03Template.processor;

public class FileKopierer: FileHandler
{
    
    StreamWriter writer;
    public  void Init()
    {
        writer = new("FileKopier.txt");
    }

    public  void Process(char c)
    {
        writer.Write(c);
    }

    public  void Dispose()
    {
        writer.Dispose();
    }
}