namespace Tag3_05Command.math;

public class Calculator
{
    private static Calculator _instance = new Calculator();

    public static Calculator Instance
    {
        get { return _instance; }
    }
    private Calculator()
    {
        Memory = 0;
    }
    
    
    
    public double Memory { get; private set; }
    
    

    public void Add(double a)
    {
        Memory += a;
    }
    
    public void Sub(double a)
    {
        Memory -= a;
    }
    public void Mult(double a)
    {
        Memory *= a;
    }
    
    public void Div(double a)
    {
        Memory /= a;
    }
    
  
    
    public void Clear()
    {
        Memory = 0;
    }
    
    public void Print()
    {
        Console.WriteLine(Memory);
    }
}