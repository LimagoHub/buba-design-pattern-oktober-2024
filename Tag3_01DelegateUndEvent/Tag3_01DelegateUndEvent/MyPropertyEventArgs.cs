namespace Tag3_01DelegateUndEvent;

public class MyPropertyEventArgs: EventArgs
{
    private readonly string propertyname;
    private readonly object oldValue;
    private readonly object newValue;

    public MyPropertyEventArgs(string propertyname, object oldValue, object newValue)
    {
        this.propertyname = propertyname;
        this.oldValue = oldValue;
        this.newValue = newValue;
    }

    public string Propertyname => propertyname;

    public object OldValue => oldValue;

    public object NewValue => newValue;

    public override string ToString()
    {
        return
            $"{nameof(Propertyname)}: {Propertyname}, {nameof(OldValue)}: {OldValue}, {nameof(NewValue)}: {NewValue}";
    }
}