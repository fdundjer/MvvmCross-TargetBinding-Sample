using Android.Widget;
using Execom.TargetBinding.Android.Bindings;
using Execom.TargetBinding.Core;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Platforms.Android.Core;

namespace Execom.TargetBinding.Android
{
    public class Setup : MvxAndroidSetup<App>
    {
        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            base.FillTargetFactories(registry);
            registry.RegisterCustomBindingFactory<ImageView>("TintColor", view => new TintColorMvxTargetBinding(view));
        }
    }
}