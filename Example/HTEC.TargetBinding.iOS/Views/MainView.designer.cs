// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace HTEC.TargetBinding.iOS.Views
{
    [Register ("MainView")]
    partial class MainView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ChangeTintColorButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        HTEC.TargetBinding.iOS.Controls.CustomUIImageView LogoImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ResetColorToDefaultButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ChangeTintColorButton != null) {
                ChangeTintColorButton.Dispose ();
                ChangeTintColorButton = null;
            }

            if (LogoImageView != null) {
                LogoImageView.Dispose ();
                LogoImageView = null;
            }

            if (ResetColorToDefaultButton != null) {
                ResetColorToDefaultButton.Dispose ();
                ResetColorToDefaultButton = null;
            }
        }
    }
}