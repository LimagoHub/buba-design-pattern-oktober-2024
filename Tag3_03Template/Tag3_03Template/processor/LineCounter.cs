namespace Tag3_03Template.processor;

public class LineCounter: AbstractCounter
{
    
    public override void Process(char c)
    {
        if (c == '\n')
            IncrementCounter();
    }
}