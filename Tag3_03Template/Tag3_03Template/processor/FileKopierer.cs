namespace Tag3_03Template.processor;

public class FileKopierer: AbstractFileProcessor
{
    
    StreamWriter writer;
    public override void Init()
    {
        writer = new("FileKopier.txt");
    }

    public override void Process(char c)
    {
        writer.Write(c);
    }

    public override void Dispose()
    {
        writer.Dispose();
    }
}