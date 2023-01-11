namespace HotReloadTest;

using Sharp.UI;
 
public partial class App : Application
{
    public static int Counter = 1;
                  
    public App()
    {
        Reloadify.Reload.Instance.ReplaceType = e => HotReload.ReplaceWithType(e.Type);
        Reloadify.Reload.Instance.FinishedReload = () => HotReload.TriggerHotReload();
        Reloadify.Reload.Init();

        Resources = AppResources.Default;
        MainPage = new TestPage();
    }
}
