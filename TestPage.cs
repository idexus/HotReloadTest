namespace HotReloadTestApp;

using Microsoft.Maui.Controls.Shapes;
using Sharp.UI;

public partial class TestPage : ContentPage
{
    int count = 0;

    Button button;

    public TestPage()
    {
        Resources = new ResourceDictionary
        {
            new Style<Label>(e => e
                .TextColor(AppColors.Gray200)
                .HorizontalOptions(LayoutOptions.Center)
                .VerticalOptions(LayoutOptions.Center)),

            new Style<Button>(e => e
                .BackgroundColor(AppColors.Gray950)
                .Padding(20)
                .CornerRadius(10))
            {
                new VisualState<Button>(VisualStates.Button.Normal, e => e
                    .FontSize(50)
                    .TextColor(AppColors.Gray200)
                    .SizeRequest(270,120)),

                new VisualState<Button>(VisualStates.Button.Disabled, e => e
                    .FontSize(35)
                    .TextColor(AppColors.Gray600)
                    .SizeRequest(180,80))
            }
        };

        Content = new Grid(e => e.BackgroundColor(Colors.Black))
        {
            new VerticalStackLayout(out var vStack, e => e.VerticalOptions(LayoutOptions.Center))
            {
                new Label(out var label)
                    .Text("Only in Code :)")
                    .FontSize(45),

                new Slider(out var slider)
                    .Minimum(1).Maximum(30)
                    .Value(e => e.Path("SliderValue"))
                    .Margin(new Thickness(50, 30))
                    .OnValueChanged(slider => button.IsEnabled = slider.Value < 10),

                new Border(e => e
                    .SizeRequest(270, 450)
                    .StrokeShape(new RoundRectangle().CornerRadius(40))
                    .BackgroundColor(AppColors.Gray950))
                {
                    new Grid(e => e.RowDefinitions(e => e.Star().Star(2).Star()))
                    {
                        new Label()
                            .Text(e => e.Path("Value").Source(slider).StringFormat("Value : {0:F1}"))
                            .FontSize(40),

                        new Image().Source("dotnet_bot.png").Row(1),

                        new Label()
                            .Text("Hello, World!")
                            .Row(2)
                            .FontSize(30)
                            .TextColor(Colors.DarkGray)
                    }
                },

                new Button(out button)
                    .Text("Click me")
                    .Margin(20)
                    .OnClicked(async (Button b) =>
                    {
                        count++;
                        b.Text = $"Clicked {count} ";
                        b.Text += count == 1 ? "time" : "times";

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