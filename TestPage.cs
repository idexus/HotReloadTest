﻿namespace HotReloadTestApp;

using Sharp.UI;

[SharpObject]
public partial class TestPage : ContentPage
{
    MyViewModel viewModel => BindingContext as MyViewModel;

    public TestPage(MyViewModel viewModel)
    {
        BindingContext = viewModel;
        Resources = AppResources.Default;

        Content = new Grid
        {
            e => e.BackgroundColor(Colors.Black),

            new VStack(out var vStack)
            {
                e => e.VerticalOptions(LayoutOptions.Center),

                new Label("Hot Reload :)")
                    .FontSize(45)
                    .TextColor(Colors.Red)
                    .HorizontalOptions(LayoutOptions.Center)
                    .Configure(label =>
                    {
                        Task.Run(async () => 
                        {
                            await Task.Delay(200);
                            _ = label.RotateTo(360, 600);
                            await vStack.RotateYTo(15, 100);
                            _ = vStack.ScaleTo(0.7, 200);
                            await vStack.RotateYTo(0, 100);
                            await vStack.RotateYTo(-15, 100);
                            await vStack.RotateYTo(0, 100);
                            _ = vStack.ScaleTo(1, 200);
                        });
                    }),

                new Slider(1, 30, 1, out var slider)
                    .Value(e => e.Path("SliderValue"))
                    .Margin(new Thickness(50, 30)),

                new Border
                {
                    e => e
                        .SizeRequest(270, 450)
                        .StrokeShape(new RoundRectangle().CornerRadius(40))
                        .BackgroundColor(AppColors.Gray950),

                    new Grid
                    {
                        e => e.RowDefinitions(e => e.Star().Star(2).Star()),

                        new Label()
                            .Text(e => e.Path("Value").Source(slider).StringFormat("Value : {0:F1}"))
                            .FontSize(40)
                            .TextColor(Colors.DarkGray)
                            .HorizontalOptions(LayoutOptions.Center)
                            .VerticalOptions(LayoutOptions.Center),

                        new Image("dotnet_bot.png").Row(1),

                        new Label("Hello, World!").Row(2)
                            .FontSize(30)
                            .TextColor(Colors.DarkGray)
                            .HorizontalOptions(LayoutOptions.Center)
                            .VerticalOptions(LayoutOptions.Center)
                    }
                },

                new Label()
                    .Text(e => e.Path("Counter"))
                    .FontSize(40)
                    .HorizontalOptions(LayoutOptions.Center)
                    .Margin(10),

                new Button("Count")
                    .BackgroundColor(AppColors.Gray950)
                    .TextColor(Colors.White)
                    .FontSize(20)
                    .WidthRequest(270)
                    .OnClicked(async (Button sender) =>
                    {
                        viewModel.Count();
                        await vStack.RotateYTo(15, 100);
                        await vStack.RotateYTo(0, 100);
                        await vStack.RotateYTo(-15, 100);
                        await vStack.RotateYTo(0, 100);
                    })
            }
        };
    }
}
