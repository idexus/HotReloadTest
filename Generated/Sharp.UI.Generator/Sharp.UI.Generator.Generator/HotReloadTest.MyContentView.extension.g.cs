﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace HotReloadTest
{
    using Sharp.UI;

    public static class MyContentViewGeneratedSharpObjectExtension
    {
        public static T Label<T>(this T obj,
            string label)
            where T : HotReloadTest.MyContentView
        {
            var mauiObject = MauiWrapper.Value<HotReloadTest.MyContentView>(obj);
            mauiObject.SetValue(HotReloadTest.MyContentView.LabelProperty, (string)label);
            return obj;
        }
        
        public static T Label<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : HotReloadTest.MyContentView
        {
            var mauiObject = MauiWrapper.Value<HotReloadTest.MyContentView>(obj);
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) mauiObject.SetValue(HotReloadTest.MyContentView.LabelProperty, builder.GetValue());
            return obj;
        }
        
        public static T Label<T>(this T obj,
            System.Func<LazyValueBuilder<string>, LazyValueBuilder<string>> buildValue)
            where T : HotReloadTest.MyContentView
        {
            var mauiObject = MauiWrapper.Value<HotReloadTest.MyContentView>(obj);
            var builder = buildValue(new LazyValueBuilder<string>());
            if (builder.ValueIsSet()) mauiObject.SetValue(HotReloadTest.MyContentView.LabelProperty, builder.GetValue());
            return obj;
        }
        
        public static T Label<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
            where T : HotReloadTest.MyContentView
        {
            var mauiObject = MauiWrapper.Value<HotReloadTest.MyContentView>(obj);
            var builder = buildBinding(new BindingBuilder<string>(mauiObject, HotReloadTest.MyContentView.LabelProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669