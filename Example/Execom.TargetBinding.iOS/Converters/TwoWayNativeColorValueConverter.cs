using System;
using System.Globalization;
using MvvmCross.Converters;
using MvvmCross.Plugin.Color.Platforms.Ios;
using MvvmCross.UI;
using UIKit;

namespace Execom.TargetBinding.iOS.Converters
{
    public class TwoWayNativeColorValueConverter : MvxValueConverter<MvxColor, UIColor>
    {
        protected override UIColor Convert(MvxColor value, Type targetType, object parameter, CultureInfo culture)
        {
            return value?.ToNativeColor();
        }

        protected override MvxColor ConvertBack(UIColor value, Type targetType, object parameter, CultureInfo culture)
        {
            value.GetRGBA(out var red, out var green, out var blue, out var alpha);
            var mvxColor = new MvxColor((int)(red * 255), (int)(green * 255), (int)(blue * 255), (int)(alpha * 255));
            return mvxColor;
        }
    }
}