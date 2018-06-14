using System;
using System.Reflection;
using Execom.TargetBinding.iOS.Controls;
using MvvmCross.Binding.Bindings.Target;
using UIKit;

namespace Execom.TargetBinding.iOS.Bindings
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