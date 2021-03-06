﻿using HTEC.TargetBinding.Core.ViewModels;
using HTEC.TargetBinding.iOS.Common;
using HTEC.TargetBinding.iOS.Converters;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace HTEC.TargetBinding.iOS.Views
{
    [MvxRootPresentation]
    public partial class MainView : MvxViewController<MainViewModel>
    {
        public MainView()
            : base(nameof(MainView), null)
        {
        }

        public override void ViewDidLoad()
        {
            LogoImageView.Image = LogoImageView.Image.ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);

            base.ViewDidLoad();
            var set = this.CreateBindingSet<MainView, MainViewModel>();
            set.Bind(ChangeTintColorButton).To(vm => vm.ChangeTintColorCommand);
            set.Bind(LogoImageView).For(v => v.TintColor).To(vm => vm.ImageTintColor).TwoWay().WithConversion(new TwoWayNativeColorValueConverter());
            set.Apply();

            ResetColorToDefaultButton.TouchUpInside += (sender, args) =>
            {
                LogoImageView.TintColor = Colors.DefaultLogoTintColor;
            };
        }
    }
}