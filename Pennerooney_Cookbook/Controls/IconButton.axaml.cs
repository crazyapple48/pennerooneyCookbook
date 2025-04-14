using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace Pennerooney_Cookbook.Controls;

public class IconButton : Button
{
    public static readonly StyledProperty<string> IconTextProperty = AvaloniaProperty.Register<IconButton, string>(
        nameof(IconText));
    

    public string IconText
    {
        get => GetValue(IconTextProperty);
        set => SetValue(IconTextProperty, value);
    }
}