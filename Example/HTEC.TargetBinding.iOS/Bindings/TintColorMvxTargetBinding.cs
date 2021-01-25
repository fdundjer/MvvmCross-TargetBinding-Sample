using System;
using System.Reflection;
using HTEC.TargetBinding.iOS.Controls;
using MvvmCross.Binding.Bindings.Target;
using UIKit;

namespace HTEC.TargetBinding.iOS.Bindings
{
    public class TintColorMvxTargetBinding : MvxWithEventPropertyInfoTargetBinding
    {
        public TintColorMvxTargetBinding(CustomUIImageView target, PropertyInfo targetPropertyInfo) 
            : base(target, targetPropertyInfo)
        {       
        }

        public override Type TargetType => typeof(UIColor);
    }
}