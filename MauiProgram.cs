using System;

namespace HotReloadTestApp
{
    using Sharp.UI;

    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            
            // vs code hot reload
            //Reloadify.Reload.Instance.ReplaceType = e => HotReload.ReplaceWithType(e.Type);
            //Reloadify.Reload.Instance.FinishedReload = () => HotReload.TriggerHotReload();
            //Reloadify.Reload.Init();

            var builder = MauiApp.CreateBuilder();
            builder
                .SharpUIApplication<App>(HotReloadSupport.IdeIPs)
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<MyViewModel>();
            builder.Services.AddSingleton<TestPage>();

            return builder.Build();
        }
    }
}

