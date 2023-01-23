
#if DEBUG
#pragma warning disable CS8632

[assembly: System.Reflection.Metadata.MetadataUpdateHandlerAttribute(typeof(ExampleApp.HotReloadService))]
namespace ExampleApp
{ 
    using Sharp.UI;

    public static class HotReloadService
    {
        internal static void ClearCache(Type[]? types) { }
        internal static void UpdateApplication(Type[]? types)
        {
            foreach(var type in types)
                HotReload.ReplaceWithType(type);
            HotReload.TriggerHotReload();
        }
    }
}

#pragma warning restore CS8632
#endif

