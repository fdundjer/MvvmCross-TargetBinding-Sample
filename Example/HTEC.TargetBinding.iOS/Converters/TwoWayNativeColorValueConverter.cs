using System;
using System.Drawing;
using System.Globalization;
using MvvmCross.Converters;
using MvvmCross.Plugin.Color.Platforms.Ios;
using UIKit;

namespace HTEC.TargetBinding.iOS.Converters
{
    public class TwoWayNativeColorValueConverter : MvxValueConverter<Color, UIColor>
    {
        protected override UIColor Convert(Color value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToNativeColor();
        }

        protected override Color ConvertBack(UIColor value, Type targetType, object parameter, CultureInfo culture)
        {
            value.GetRGBA(out var red, out var green, out var blue, out var alpha);
            var color = Color.FromArgb((int)(alpha * 255), (int)(red * 255), (int)(green * 255), (int)(blue * 255));
            return color;
        }
    }
}