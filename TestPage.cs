namespace HotReloadTestApp;

using Microsoft.Maui.Controls.Shapes;
using Sharp.UI;

public partial class TestPage : ContentPage
{
    int count = 0;

    VerticalStackLayout vStack;
    Label label;

    public TestPage()
    {
        Content = new Grid
        {
            e => e.BackgroundColor(Colors.Black),

            new VerticalStackLayout
            {
                e => e
                    .Assign(out vStack)
                    .VerticalOptions(LayoutOptions.Center),

                new Label()
                    .Assign(out label)
                    .Text("Only in Code :)")
                    .FontSize(45)
                    .TextColor(AppColors.Gray200)
                    .HorizontalOptions(LayoutOptions.Center),

                new Slider()
                    .Minimum(1).Maximum(30)
                    .Assign(out var slider)
                    .Value(e => e.Path("SliderValue"))
                    .Margin(new Thickness(50, 30)),

                new Border()
                    .Content(new Grid()
                    {
                        e => e.RowDefinitions(e => e.Star().Star(2).Star()),

                        new Label()
                            .Text(e => e.Path("Value").Source(slider).StringFormat("Value : {0:F1}"))
                            .FontSize(40)
                            .TextColor(Colors.DarkGray)
                            .HorizontalOptions(LayoutOptions.Center)
                            .VerticalOptions(LayoutOptions.Center),

                        new Image().Source("dotnet_bot.png").Row(1),

                        new Label()
                            .Text("Hello, World!")
                            .Row(2)
                            .FontSize(30)
                            .TextColor(Colors.DarkGray)
                            .HorizontalOptions(LayoutOptions.Center)
                            .VerticalOptions(LayoutOptions.Center)
                    })
                    .SizeRequest(270, 450)
                    .StrokeShape(new RoundRectangle().CornerRadius(40))
                    .BackgroundColor(AppColors.Gray950),

                new Button()
                    .Text("Click me")
                    .Padding(20)
                    .Margin(20)
                    .BackgroundColor(AppColors.Gray950)
                    .TextColor(Colors.White)
                    .FontSize(20)
                    .WidthRequest(270)
                    .CornerRadius(10)
                    .OnClicked(async (Button button) =>
                    {
                        count++;
                        button.Text = $"Clicked {count} ";
                        button.Text += count == 1 ? "time" : "times";

                        await vStack.RotateYTo(15, 100);
                        await vStack.RotateYTo(0, 100);
                        await vStack.RotateYTo(-15, 100);
                        await vStack.RotateYTo(0, 100);

                        await label.RotateTo(360 * (count % 2), 300);
                    })
            }
        };
    }
}