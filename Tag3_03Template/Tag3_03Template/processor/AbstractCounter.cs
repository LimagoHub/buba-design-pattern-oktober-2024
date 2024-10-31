namespace Tag3_03Template.processor;

public abstract class AbstractCounter: FileHandler
{
    private int counter;

    public int Counter => counter;

    protected void IncrementCounter()
    {
        counter++;
    }

    public void Init()
    {
        counter = 0;
    }

    public void Dispose()
    {
        Console.WriteLine(counter);
    }

    public abstract void Process(char c);
}