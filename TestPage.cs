namespace HotReloadTestApp;

using Microsoft.Maui.Controls.Shapes;
using Sharp.UI;

public partial class TestPage : ContentPage
{
    int count = 0;

    VerticalStackLayout vStack;
    Button button;
    Label label;

    public TestPage()
    {
        Resources = new ResourceDictionary
        {
            new Style<Label>(e => e
                .TextColor(AppColors.Gray200)
                .CenterInContainer()),

            new Style<Button>(e => e
                .BackgroundColor(AppColors.Gray950)
                .Padding(20)
                .CornerRadius(10)
                .WidthRequest(300))
            {
                new VisualState<Button>(VisualStates.Button.Normal, e => e
                    .FontSize(33)
                    .TextColor(AppColors.Gray200))
                {
                    async button => {
                        await button.RotateTo(0);   // create animations inside VisualState
                    }
                },

                new VisualState<Button>(VisualStates.Button.Disabled, e => e
                    .FontSize(20)
                    .TextColor(AppColors.Gray600))
                {
                    async button => {
                        await button.RotateTo(180);
                    }
                },
            }
        };

        Content = new Grid
        {
            e => e.BackgroundColor(Colors.Black),

            new VerticalStackLayout
            {
                e => e
                    .Assign(out vStack)
                    .CenterVertically(),

                new Label()
                    .Assign(out label)
                    .Text("Only in Code :)")
                    .FontSize(45),

                new Slider()
                    .Assign(out var slider)
                    .Minimum(1).Maximum(30)
                    .Value(e => e.Path("SliderValue"))
                    .Margin(50, 30)
                    .OnValueChanged(slider => button.IsEnabled = slider.Value < 10),

                new Border()
                    .Content(new Grid()
                    {
                        e => e.RowDefinitions(e => e.Star(1.3).Star(3).Star(count: 2)),

                        new Label()
                            .Text(e => e.Path("Value").Source(slider).StringFormat("Value : {0:F1}"))
                            .FontSize(40),

                        new Image().Source("dotnet_bot.png").Row(1),

                        new Label()
                            .Text("Hello, World!")
                            .Row(2)
                            .FontSize(30)
                            .TextColor(Colors.DarkGray),

                        new Switch().Row(3)
                            .Assign(out var testSwitch)
                            .CenterInContainer()
                    })
                    .SizeRequest(270, 450)
                    .StrokeShape(new RoundRectangle().CornerRadius(40))
                    .BackgroundColor(AppColors.Gray950)
                    .VisualStateGroups(new VisualStateGroupList
                    {
                        new VisualState<Border> {
                            async border => {
                                await border.AnimateBackgroundColorTo(Colors.Red, 500);
                                await label.RotateXTo(360, 400);
                            },
                            new StateTrigger().IsActive(e => e.Path("IsToggled").Source(testSwitch))
                        },

                        new VisualState<Border> {
                            async border => {
                                await border.AnimateBackgroundColorTo(AppColors.Gray950, 500);
                                await label.RotateXTo(0, 400);
                            },
                            new StateTrigger().IsActive(e => e.Path("IsToggled").Source(testSwitch).Negate())
                        }
                    }),

                new Button()
                    .Text("Click me")
                    .Assign(out button)
                    .Margin(30)
                    .OnClicked(async (Button b) =>
                    {
                        count++;
                        b.Text = $"Clicked {count} ";
                        b.Text += count == 1 ? "time" : "times";
                        
                        await vStack.RotateYTo(((count % 4) switch { 0 => 0, 1 => 20, 2 => 0, _ => -20 }));
                        await label.RotateTo(360 * (count % 2), 300);
                    })
            }
        };
    }
}