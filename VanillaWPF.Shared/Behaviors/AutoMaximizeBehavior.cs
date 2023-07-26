using Microsoft.Xaml.Behaviors;
using System.Windows;

namespace VanillaWPF.Shared.Behaviors;

/// <summary>
/// Behavior that maximizes the window when it is loaded
/// </summary>
public class AutoMaximizeBehavior : Behavior<Window>
{
    protected override void OnAttached()
    {
        AssociatedObject.Loaded -= OnLoaded;
        AssociatedObject.Loaded += OnLoaded;
    }

    protected override void OnDetaching()
    {
        AssociatedObject.Loaded -= OnLoaded;
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        AssociatedObject.WindowState = WindowState.Maximized;
    }
}
