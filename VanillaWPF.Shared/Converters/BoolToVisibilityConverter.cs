using System;
using System.Windows;
using System.Windows.Data;

namespace VanillaWPF.Shared.Converters;

/// <summary>
/// Converts a boolean to a visibility value
/// </summary>
public class BoolToVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is not bool @bool)
            return DependencyProperty.UnsetValue;
        return @bool ? Visibility.Visible : Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is not Visibility vis)
            return DependencyProperty.UnsetValue;
        return vis == Visibility.Visible;
    }
}
