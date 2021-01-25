using Android.Widget;
using HTEC.TargetBinding.Android.Bindings;
using HTEC.TargetBinding.Core;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Platforms.Android.Core;

namespace HTEC.TargetBinding.Android
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