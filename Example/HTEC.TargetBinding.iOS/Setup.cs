using HTEC.TargetBinding.Core;
using HTEC.TargetBinding.iOS.Bindings;
using HTEC.TargetBinding.iOS.Controls;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Platforms.Ios.Core;

namespace HTEC.TargetBinding.iOS
{
    public class Setup : MvxIosSetup<App>
    {
        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            registry.RegisterPropertyInfoBindingFactory(typeof(TintColorMvxTargetBinding), typeof(CustomUIImageView), nameof(CustomUIImageView.TintColor));
            base.FillTargetFactories(registry);
        }
    }
}