namespace Tag3_02Delegate;

class Program
{

    public delegate int MyFooType();
    
    public delegate double Operation(double a, double b);
    
    static void Main(string[] args)
    {
        new Program().run();
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
    
    public double Sub(double a, double b)
    {
        return a - b;
    }


    
    
    int foo()
    {
        return 4711;
    }
    
    private void run()
    {
        Operation [] ops = {Add, Sub};
        
        double a = 1.0;
        double b = 2.0;

        for (int i = 0; i < ops.Length; i++)
        {
            Console.WriteLine(ops[i](a,b));
        }
        
        MyFooType ptr = foo;
        int result = ptr();
        Console.WriteLine(result);
    }
}