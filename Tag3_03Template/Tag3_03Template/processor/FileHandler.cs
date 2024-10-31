namespace Tag3_03Template.processor;

public interface FileHandler
{
    void Init();
    void Dispose();
    void Process(char c);
}