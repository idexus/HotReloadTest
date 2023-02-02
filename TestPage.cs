namespace HotReloadTestApp;

using Sharp.UI;
using System.Linq;


public partial class TestPage : ContentPage 
{
    MyViewModel viewModel => BindingContext as MyViewModel;

    public TestPage(MyViewModel viewModel)
    {
        BindingContext = viewModel;
        Resources = AppResources.Default;
        Content = new Grid
        {
            new VStack
            {
                new Label("Hot Reload Test")
                    .FontSize(e => e.Default(43).OnDesktop(60))
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
                            .FontSize(e => e.Default(40).OnDesktop(50))
                            .Text(e => e.Path("Value").Source(slider).StringFormat("Value : {0:F1}"))
                            .HorizontalOptions(LayoutOptions.Center)
                            .VerticalOptions(LayoutOptions.Center)
                            .TextColor(AppColors.Gray200),

                        new Image("dotnet_bot.png").Row(1),

                        new Label("Hello, World").Row(2)
                            .FontSize(e => e.Default(30).OnDesktop(40))
                            .HorizontalOptions(LayoutOptions.Center)
                            .VerticalOptions(LayoutOptions.Center)
                            .TextColor(AppColors.Gray200)

                    }
                    .RowDefinitions(e => e.Star().Star(2).Star())
                }
                .WidthRequest(e => e.Default(250).OnDesktop(300))
                .HeightRequest(e => e.Default(400).OnDesktop(500))
                .StrokeShape(new RoundRectangle().CornerRadius(30))
                .BackgroundColor(Colors.DarkSlateGray),

                new Label()
                    .Text(e => e.Path("Counter").StringFormat("Counter : {0}"))
                    .TextColor(Colors.Red)
                    .FontSize(e => e.Default(50).OnAndroid(40))
                    .HorizontalOptions(LayoutOptions.Center)
                    .Margin(20),

                new Button("Count")
                    .WidthRequest(e => e.Default(300).OnAndroid(250))
                    .FontSize(27)
                    .OnClicked(button => viewModel.Count())

            }
            .VerticalOptions(LayoutOptions.Center)
        }
        .BackgroundColor(AppColors.Gray950);
    }
}
