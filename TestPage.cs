namespace HotReloadTest;

using Sharp.UI;
using System.Linq;


[SharpObject]
[ViewModel(typeof(MyViewModel))] 
public partial class TestPage : ContentPage 
{
    public TestPage()
    {
        Resources = AppResources.Default;
        Content = new Grid
        {
            new VStack
            {
                new Label("Hot Reload Test")
                    .FontSize(60)
                    .TextColor(Colors.Red)
                    .HorizontalOptions(LayoutOptions.Center),

                new Slider(1, 20, 1, out var slider)
                    .Value(e => e.Path("SliderValue"))
                    .Margin(new Thickness(80, 30)),

                new Border
                {
                    new Grid
                    {
                        new Label()
                            .FontSize(40)
                            .Text(e => e.Path("Value").Source(slider).StringFormat("Value : {0:F1}"))
                            .HorizontalOptions(LayoutOptions.Center)
                            .VerticalOptions(LayoutOptions.Center)
                            .TextColor(AppColors.Gray200),

                        new Image("dotnet_bot.png").Row(1),

                        new Label("Hello, World").Row(2)
                            .FontSize(40)
                            .HorizontalOptions(LayoutOptions.Center)
                            .VerticalOptions(LayoutOptions.Center)
                            .TextColor(AppColors.Gray200)

                    }
                    .RowDefinitions(e => e.Star().Star(2).Star())
                }
                .SizeRequest(300, 500)
                .StrokeShape(new RoundRectangle().CornerRadius(30))
                .BackgroundColor(Colors.DarkSlateGray),

                new Label()
                    .Text(e => e.Path("Counter").StringFormat("Counter : {0}"))
                    .TextColor(Colors.Red)
                    .FontSize(50)
                    .HorizontalOptions(LayoutOptions.Center)
                    .Margin(20),

                new Button("Count")
                    .WidthRequest(300)
                    .FontSize(30)
                    .Command(e => e.Path("CountCommand"))

            }
            .VerticalOptions(LayoutOptions.Center)
        }
        .BackgroundColor(AppColors.Gray950);
    }
}