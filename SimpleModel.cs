namespace HotReloadTest;

public class SimpleModel : BindableObject
{       
    static SimpleModel _current = new SimpleModel();
    public static SimpleModel Current => _current;

    public static readonly Microsoft.Maui.Controls.BindableProperty CounterProperty =
        BindableProperty.Create(
            nameof(Counter),
            typeof(int),
            typeof(SimpleModel),
            0);

    public int Counter
    {
        get => (int)GetValue(CounterProperty);
        set => SetValue(CounterProperty, value);
    }
}
