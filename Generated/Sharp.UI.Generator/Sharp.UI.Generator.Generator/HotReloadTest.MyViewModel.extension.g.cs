﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace HotReloadTestApp
{
    using Sharp.UI;

    public static class MyViewModelGeneratedSharpObjectExtension
    {
        public static T Counter<T>(this T obj,
            int counter)
            where T : HotReloadTestApp.MyViewModel
        {
            var mauiObject = MauiWrapper.Value<HotReloadTestApp.MyViewModel>(obj);
            mauiObject.SetValue(HotReloadTestApp.MyViewModel.CounterProperty, (int)counter);
            return obj;
        }
        
        public static T Counter<T>(this T obj,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buildValue)
            where T : HotReloadTestApp.MyViewModel
        {
            var mauiObject = MauiWrapper.Value<HotReloadTestApp.MyViewModel>(obj);
            var builder = buildValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) mauiObject.SetValue(HotReloadTestApp.MyViewModel.CounterProperty, builder.GetValue());
            return obj;
        }
        
        public static T Counter<T>(this T obj,
            System.Func<LazyValueBuilder<int>, LazyValueBuilder<int>> buildValue)
            where T : HotReloadTestApp.MyViewModel
        {
            var mauiObject = MauiWrapper.Value<HotReloadTestApp.MyViewModel>(obj);
            var builder = buildValue(new LazyValueBuilder<int>());
            if (builder.ValueIsSet()) mauiObject.SetValue(HotReloadTestApp.MyViewModel.CounterProperty, builder.GetValue());
            return obj;
        }
        
        public static T Counter<T>(this T obj,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buildBinding)
            where T : HotReloadTestApp.MyViewModel
        {
            var mauiObject = MauiWrapper.Value<HotReloadTestApp.MyViewModel>(obj);
            var builder = buildBinding(new BindingBuilder<int>(mauiObject, HotReloadTestApp.MyViewModel.CounterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T SliderValue<T>(this T obj,
            double sliderValue)
            where T : HotReloadTestApp.MyViewModel
        {
            var mauiObject = MauiWrapper.Value<HotReloadTestApp.MyViewModel>(obj);
            mauiObject.SetValue(HotReloadTestApp.MyViewModel.SliderValueProperty, (double)sliderValue);
            return obj;
        }
        
        public static T SliderValue<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : HotReloadTestApp.MyViewModel
        {
            var mauiObject = MauiWrapper.Value<HotReloadTestApp.MyViewModel>(obj);
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) mauiObject.SetValue(HotReloadTestApp.MyViewModel.SliderValueProperty, builder.GetValue());
            return obj;
        }
        
        public static T SliderValue<T>(this T obj,
            System.Func<LazyValueBuilder<double>, LazyValueBuilder<double>> buildValue)
            where T : HotReloadTestApp.MyViewModel
        {
            var mauiObject = MauiWrapper.Value<HotReloadTestApp.MyViewModel>(obj);
            var builder = buildValue(new LazyValueBuilder<double>());
            if (builder.ValueIsSet()) mauiObject.SetValue(HotReloadTestApp.MyViewModel.SliderValueProperty, builder.GetValue());
            return obj;
        }
        
        public static T SliderValue<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : HotReloadTestApp.MyViewModel
        {
            var mauiObject = MauiWrapper.Value<HotReloadTestApp.MyViewModel>(obj);
            var builder = buildBinding(new BindingBuilder<double>(mauiObject, HotReloadTestApp.MyViewModel.SliderValueProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
