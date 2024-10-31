namespace Tag3_01DelegateUndEvent;

class Program
{
    
    private Metzger _metzger = new();
    private Spediteur _spediteur = new();
    static void Main(string[] args)
    {
        new Program().run();
    }

    private void run()
    {
        Schwein piggy = new Schwein("Miss Piggy");

        //piggy.AddPigTooFatListener(_metzger.Schlachten);
        //piggy.AddPigTooFatListener(_spediteur.Fahren);

        //piggy.SchweinEvent += _metzger.Schlachten;
        //piggy.SchweinEvent += _spediteur.Fahren;
        
        
        for (int i = 0; i < 11; i++)
        {
            piggy.Fuettern();
        }
        
        
        Console.WriteLine("Hello, World!");
    }

    
}

class Metzger
{
    public void Schlachten(object sender)
    {
        Console.WriteLine("Messer wetz");
    }
}

class Spediteur
{
    public void Fahren(object sender)
    {
        Console.WriteLine("Wir fahren auf der Autobahn");
    }
}

class SchweineMetzgerAdapter : PigTooFatListener
{
    private Metzger _metzger;

    public SchweineMetzgerAdapter(Metzger metzger)
    {
        _metzger = metzger;
    }

    public void PigTooFat(Schwein sender)
    {
        _metzger.Schlachten(sender);
    }
}