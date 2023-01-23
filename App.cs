namespace HotReloadTest;

using System;
using System.IO;
using System.IO.Pipes;
using System.Reflection;
using System.Runtime;
using System.Runtime.Loader;
using Sharp.UI;
using System.Reflection.Emit;
using System.Threading;


public partial class App : Application
{     
    public App()  
    {
        MainPage = new TestPage();
    }
}
