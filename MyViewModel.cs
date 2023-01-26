namespace HotReloadTest;

using Sharp.UI;
using System.Windows.Input;

[BindableProperties]
public interface IMyViewModel
{
    int Counter { get; set; }
    double SliderValue { get; set; }
}

[SharpObject]
public partial class MyViewModel : BindableObject, IMyViewModel
{
    public void Count()
    {
        Counter += 1;
    }
}
