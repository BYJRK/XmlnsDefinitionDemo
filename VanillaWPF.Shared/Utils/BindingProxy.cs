using System.Windows;

namespace VanillaWPF.Shared.Utils;

/// <summary>
/// A useful proxy for writing binding expressions in XAML
/// </summary>
public class BindingProxy : Freezable
{
    public static readonly DependencyProperty DataProperty = DependencyProperty.Register(
        nameof(Data),
        typeof(object),
        typeof(BindingProxy),
        new UIPropertyMetadata(null)
    );

    public object Data
    {
        get { return GetValue(DataProperty); }
        set { SetValue(DataProperty, value); }
    }

    protected override Freezable CreateInstanceCore()
    {
        return new BindingProxy();
    }
}
