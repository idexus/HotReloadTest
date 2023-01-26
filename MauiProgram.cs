using System;

namespace HotReloadTest
{
    using Sharp.UI;

    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<MyViewModel>();
            builder.Services.AddSingleton<TestPage>();

            var mauiApp = builder.Build();

            // vs code hot reload
            Reloadify.Reload.Instance.ReplaceType = e => HotReload.ReplaceWithType(e.Type);
            Reloadify.Reload.Instance.FinishedReload = () => HotReload.TriggerHotReload();
            Reloadify.Reload.Init();

            // vs 2022 mac
            HotReload.InitSharpUIHotReload<App>(mauiApp);

            return mauiApp;
        }
    }
}

