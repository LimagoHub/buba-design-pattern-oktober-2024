using System.Diagnostics;

namespace Tag3_03Template.processor;

public abstract class AbstractFileProcessor
{
    public void Run(string filename)
    {
        using (var reader = new StreamReader(filename))
        {
            Init();
            int zeichen;

            while ((zeichen = reader.Read()) != -1)
            {
               Process((char)zeichen);
            }

            Dispose();

        }
    }

    public virtual void Init()
    {
        // NOP
    }
    
    public abstract void Process(char c);
    public virtual void Dispose()
    {
        // NOP
    }
}