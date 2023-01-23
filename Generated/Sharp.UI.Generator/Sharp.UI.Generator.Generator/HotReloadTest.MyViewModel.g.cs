﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace HotReloadTest
{  
    using Sharp.UI;

    public partial class MyViewModel
    {
        // ----- constructors -----

        public MyViewModel(out MyViewModel myViewModel) : this()
        {
            myViewModel = this;
        }

        public MyViewModel(System.Action<MyViewModel> configure) : this()
        {
            configure(this);
        }

        public MyViewModel(out MyViewModel myViewModel, System.Action<MyViewModel> configure) : this()
        {
            myViewModel = this;
            configure(this);
        }

        // ----- bindable properties -----

        public static readonly Microsoft.Maui.Controls.BindableProperty CounterProperty =
            BindableProperty.Create(
                nameof(Counter),
                typeof(int),
                typeof(HotReloadTest.MyViewModel),
                default(int));

        public int Counter
        {
            get => (int)GetValue(CounterProperty);
            set => SetValue(CounterProperty, value);
        }

        public static readonly Microsoft.Maui.Controls.BindableProperty SliderValueProperty =
            BindableProperty.Create(
                nameof(SliderValue),
                typeof(double),
                typeof(HotReloadTest.MyViewModel),
                default(double));

        public double SliderValue
        {
            get => (double)GetValue(SliderValueProperty);
            set => SetValue(SliderValueProperty, value);
        }

        // ----- set value method -----

        public new void SetValue(Microsoft.Maui.Controls.BindableProperty property, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            ((Microsoft.Maui.Controls.BindableObject)this).SetValue(property, mauiValue);
        }

        public new void SetValue(Microsoft.Maui.Controls.BindablePropertyKey propertyKey, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            ((Microsoft.Maui.Controls.BindableObject)this).SetValue(propertyKey, mauiValue);
        }
    }
}

#pragma warning restore CS8669