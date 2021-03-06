﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

using ScriptGen.Common;

namespace ScriptGen.BindingConverter
{
    public class PhysicalVisibleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => (ModelType)value == ModelType.Physical ? Visibility.Visible : Visibility.Collapsed;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => null;
    }
}
