namespace HotReloadTest;

using Sharp.UI;

[BindableProperties]
public interface MyContentViewProperties
{
    string Label { get; set; }
}

[SharpObject]
public partial class MyContentView : ContentView, MyContentViewProperties
{
    public MyContentView()
    {
        this.BindingContext = this;
        Content = new Border
        { 
            new HStack
            { 
                new Label()
                    .Text(e => e.Path("Label"))
                    .FontSize(28)
                    .TextColor(Colors.Blue),

                new Image("dotnet_bot.png")
                    .HeightRequest(100)
                    .WidthRequest(100)
            }
            .HorizontalOptions(LayoutOptions.Center)
        };
    }
}