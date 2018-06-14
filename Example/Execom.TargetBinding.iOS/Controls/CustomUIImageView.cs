using System;
using System.ComponentModel;
using UIKit;

namespace Execom.TargetBinding.iOS.Controls
{
    [DesignTimeVisible(true)]
    [Category("Custom Controls")]
    public partial class CustomUIImageView : UIImageView
    {
        public CustomUIImageView(IntPtr handle)
            : base(handle)
        {
        }

        public event EventHandler TintColorChanged;

        public override UIColor TintColor
        {
            get => base.TintColor;
            set
            {
                base.TintColor = value;
                TintColorChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}