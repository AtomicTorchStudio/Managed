using Noesis;
using System;
using System.ComponentModel;
using System.Reflection;

namespace NoesisApp
{
    /// <summary>
    /// An action that will change a property to a specified value when invoked.
    /// </summary>
    public class ChangePropertyAction : TargetedTriggerAction<object>
    {
        public new ChangePropertyAction Clone()
        {
            return (ChangePropertyAction)base.Clone();
        }

        public new ChangePropertyAction CloneCurrentValue()
        {
            return (ChangePropertyAction)base.CloneCurrentValue();
        }

        /// <summary>
        /// Gets or sets the name of the property to change
        /// </summary>
        public string PropertyName
        {
            get { return (string)GetValue(PropertyNameProperty); }
            set { SetValue(PropertyNameProperty, value); }
        }

        public static readonly DependencyProperty PropertyNameProperty = DependencyProperty.Register(
            "PropertyName", typeof(string), typeof(ChangePropertyAction),
            new PropertyMetadata(string.Empty, OnPropertyNameChanged));

        static void OnPropertyNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ChangePropertyAction action = (ChangePropertyAction)d;
            action._property = null;
        }

        /// <summary>
        /// Gets or sets the value to set
        /// </summary>
        public object Value
        {
            get { return GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
            "Value", typeof(object), typeof(ChangePropertyAction),
            new PropertyMetadata(null, OnValueChanged));

        static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ChangePropertyAction action = (ChangePropertyAction)d;
            action.UpdateConvertedValue();
        }

        /// <summary>
        /// Gets or sets the duration of the animation that will occur when the action is invoked
        /// </summary>
        public Duration Duration
        {
            get { return (Duration)GetValue(DurationProperty); }
            set { SetValue(DurationProperty, value); }
        }

        public static readonly DependencyProperty DurationProperty = DependencyProperty.Register(
            "Duration", typeof(Duration), typeof(ChangePropertyAction),
            new PropertyMetadata(new Duration(), OnDurationChanged));

        static void OnDurationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //ChangePropertyAction action = (ChangePropertyAction)d;
        }

        /// <summary>
        /// Increment by value if true and property can be incremented; otherwise set value directly
        /// </summary>
        public bool Increment
        {
            get { return (bool)GetValue(IncrementProperty); }
            set { SetValue(IncrementProperty, value); }
        }

        public static readonly DependencyProperty IncrementProperty = DependencyProperty.Register(
            "Increment", typeof(bool), typeof(ChangePropertyAction),
            new PropertyMetadata(false, OnIncrementChanged));

        static void OnIncrementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //ChangePropertyAction action = (ChangePropertyAction)d;
        }

        protected override void Invoke(object parameter)
        {
            if (AssociatedObject != null && Target != null)
            {
                if (_property == null)
                {
                    if (UpdateProperty())
                    {
                        UpdateConvertedValue();
                    }
                }

                if (_property != null)
                {
                    DataBindingHelper.EnsureBindingValue(this, ValueProperty);

                    SetPropertyValue();
                }
            }
        }

        private bool UpdateProperty()
        {
            Type oldType = _property != null ? _property.PropertyType : null;

            _property = null;
            _converter = null;

            object target = Target;
            string propName = PropertyName;
            if (target != null && !string.IsNullOrEmpty(propName))
            {
                Type targetType = target.GetType();
                DependencyProperty prop = GetDependencyPropertyByName(targetType, propName + "Property");

                if (prop == null)
                {
                    prop = TryFindAttachedProperty(ref targetType, propName);
                }

                if (prop == null)
                {
                    throw new InvalidOperationException(string.Format(
                        "Property '{0}' not found in target '{1}'",
                        propName, targetType));
                }
                if (prop.ReadOnly)
                {
                    throw new InvalidOperationException(string.Format(
                        "Property '{0}.{1}' is read-only",
                        targetType, propName));
                }

                _property = prop;
            }

            Type newType = _property != null ? _property.PropertyType : null;

            if (oldType != newType)
            {
                if (newType != typeof(object))
                {
                    _converter = TypeDescriptor.GetConverter(newType);
                }
                return true;
            }

            return false;
        }
        
        public static DependencyProperty GetDependencyPropertyByName(Type dependencyObjectType, string name)
        {
            var bindingFlags = BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy;
            var propertyInfo = dependencyObjectType.GetProperty(name, bindingFlags);
            if (propertyInfo != null)
            {
                return propertyInfo.GetValue(null) as DependencyProperty;
            }

            var fieldInfo = dependencyObjectType.GetField(name, bindingFlags);
            if (fieldInfo != null)
            {
                return fieldInfo.GetValue(null) as DependencyProperty;
            }

            return null;
        }

        private static DependencyProperty TryFindAttachedProperty(ref Type targetType, string fullName)
        {
            var indexOfDot = fullName.IndexOf('.');
            if (indexOfDot <= 0)
            {
                return null;
            }

            var typeName = fullName.Substring(0, indexOfDot);
            var type = Noesis.Extend.FindType("Noesis." + typeName);
            if (type == null)
            {
                return null;
            }

            targetType = type;

            var propertyName = fullName.Substring(indexOfDot + 1) + "Property";
            return GetDependencyPropertyByName(targetType, propertyName);
        }

        private void UpdateConvertedValue()
        {
            _convertedValue = Value;

            if (_converter != null)
            {
                try
                {
                    if (Value != null)
                    {
                        _convertedValue = _converter.ConvertFrom(Value);
                    }
                }
                catch (NotSupportedException) { }
                catch (Exception) { }
            }
        }

        private void SetPropertyValue()
        {
            ((DependencyObject)Target).SetValue(this._property, _convertedValue);
        }

        private DependencyProperty _property;
        private TypeConverter _converter;
        private object _convertedValue;
    }
}
