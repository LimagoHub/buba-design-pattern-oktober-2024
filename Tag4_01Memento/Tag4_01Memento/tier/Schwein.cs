namespace Tag4_01Memento.tier;

public class Schwein
{
    private string name;
    private int gewicht;

    public Schwein(string name)
    {
        this.name = name;
        this.gewicht = 10;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Gewicht
    {
        get => gewicht;
        private set => gewicht = value;
    }

    public void fuettern()
    {
        Gewicht++;
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Gewicht)}: {Gewicht}";
    }

    public SchweineMemento GetMemento()
    {
        return new MySchweineMemento(name, gewicht);
    }

    public void SetMemento(SchweineMemento memento)
    {
        MySchweineMemento myMemento = (MySchweineMemento) memento;
        Name = myMemento.Name;
        Gewicht = myMemento.Gewicht;
    }
    
    private class MySchweineMemento : SchweineMemento
    {
        public string Name { get; }
        public int Gewicht { get; }

        public MySchweineMemento(string name, int gewicht)
        {
            Name = name;
            Gewicht = gewicht;
        }
    }
}