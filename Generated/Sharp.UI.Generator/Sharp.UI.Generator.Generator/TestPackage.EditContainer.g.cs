﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace TestPackage
{  
    using Sharp.UI;

    public partial class EditContainer
    {
        // ----- constructors -----

        public EditContainer(out EditContainer editContainer) : this()
        {
            editContainer = this;
        }

        public EditContainer(System.Action<EditContainer> configure) : this()
        {
            configure(this);
        }

        public EditContainer(out EditContainer editContainer, System.Action<EditContainer> configure) : this()
        {
            editContainer = this;
            configure(this);
        }

        // ----- bindable properties -----

        public static readonly Microsoft.Maui.Controls.BindableProperty NameProperty =
            BindableProperty.Create(
                nameof(Name),
                typeof(string),
                typeof(TestPackage.EditContainer),
                (string)"NoName");

        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }
        
        public static readonly Microsoft.Maui.Controls.BindableProperty EditEntryProperty =
            BindableProperty.Create(
                nameof(EditEntry),
                typeof(Sharp.UI.Entry),
                typeof(TestPackage.EditContainer),
                default(Sharp.UI.Entry));

        public Sharp.UI.Entry EditEntry
        {
            get => (Sharp.UI.Entry)GetValue(EditEntryProperty);
            set => SetValue(EditEntryProperty, value);
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
