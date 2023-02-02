namespace HotReloadTestApp;

using Sharp.UI;


public partial class App : Application
{
    public App()
    {
        MainPage = ActivatorUtilities.CreateInstance<TestPage>(Application.Services);
    }
}
