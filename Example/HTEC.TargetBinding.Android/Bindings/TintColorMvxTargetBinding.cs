using System;
using Android.Graphics;
using Android.Widget;
using MvvmCross.Binding;
using MvvmCross.Binding.Bindings.Target;

namespace HTEC.TargetBinding.Android.Bindings
{
    public class TintColorMvxTargetBinding : MvxTargetBinding<ImageView, Color>
    {
        public TintColorMvxTargetBinding(ImageView target)
            : base(target)
        {
        }

        public override MvxBindingMode DefaultMode => MvxBindingMode.OneWay;

        protected override void SetValue(Color value)
        {
            Target.SetColorFilter(value);
        }
    }
}