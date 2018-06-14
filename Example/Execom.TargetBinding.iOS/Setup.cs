using Execom.TargetBinding.Core;
using Execom.TargetBinding.iOS.Bindings;
using Execom.TargetBinding.iOS.Controls;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Platforms.Ios.Core;

namespace Execom.TargetBinding.iOS
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