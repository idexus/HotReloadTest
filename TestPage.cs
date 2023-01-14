namespace HotReloadTest;
using Sharp.UI;

public partial class TestPage : ContentPage
{
    public TestPage()
    {
        this.BindingContext = SimpleModel.Current;
        Content = new Grid
        {
            new VStack
            {
                new Label("Hot Reload Test")
                    .FontSize(60)
                    .TextColor(Colors.Red)
                    .HorizontalOptions(LayoutOptions.Center),

                new Slider(1, 100, 1, out var slider)
                    .Margin(new Thickness(50, 20)),

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
                            .FontSize(30)
                            .TextColor(AppColors.Gray200)
                            .HorizontalOptions(LayoutOptions.Center)
                            .VerticalOptions(LayoutOptions.Center)
                    }
                    .RowDefinitions(e => e.Star().Star(2).Star())
                }
                .SizeRequest(300, 500)
                .StrokeShape(new RoundRectangle().CornerRadius(30))
                .BackgroundColor(Colors.DarkSlateGray),

                new Label()
                    .Text(e => e.Path("Counter").StringFormat("Counter : {0}"))
                    .TextColor(Colors.Red)
                    .FontSize(40)
                    .HorizontalOptions(LayoutOptions.Center)
                    .Margin(20),

                new Button("Count")
                    .WidthRequest(300)
                    .FontSize(30)
                    .OnClicked(button =>
                    {
                        SimpleModel.Current.Counter += 1;
                    })
            }
            .VerticalOptions(LayoutOptions.Center)
        }
        .Background(AppColors.Gray950);
    }
}
