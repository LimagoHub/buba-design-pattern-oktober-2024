namespace Tag3_03Template.processor;

public abstract class AbstractCounter: AbstractFileProcessor
{
    private int counter;

    public int Counter => counter;

    protected void IncrementCounter()
    {
        counter++;
    }

    public override void Init()
    {
        counter = 0;
    }

    public override void Dispose()
    {
        Console.WriteLine(counter);
    }
}