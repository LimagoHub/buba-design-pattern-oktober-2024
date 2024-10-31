using System.ComponentModel;

namespace Tag3_01DelegateUndEvent;

public class Schwein
{
    public delegate void SchweinDelegate(object sender); 
    //public delegate void EventHandler<TEventArgs>(object? sender, TEventArgs e);
    
    public event SchweinDelegate SchweinEvent;
    public event EventHandler PropertyChangedEvent;
    
    //private List<SchweinDelegate> _pigTooFatListeners = new();
    
    private string _name;
    private int _gewicht;

    public Schwein(string name)
    {
        this._name = name;
        this._gewicht = 10;
       
    }

    /*public void AddPigTooFatListener(SchweinDelegate listener)
    {
        _pigTooFatListeners.Add(listener);
    }*/

    /*private void firePigyTooFatEvent()
    {
        foreach (var listener in _pigTooFatListeners)
        {
            listener(this);
        }
    }*/

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Gewicht
    {
        get => _gewicht;
        private set
        {
            _gewicht = value;
            if(_gewicht > 20) SchweinEvent?.Invoke(this);
        }
    }

    public void Fuettern()
    {
        Gewicht ++;
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Gewicht)}: {Gewicht}";
    }
}