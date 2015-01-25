// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace L04_Navigation
{
	[Register ("FinalViewController")]
	partial class FinalViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnBack { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel MyLabel { get; set; }

		[Action ("btnBack_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnBack_TouchUpInside (UIButton sender);

		[Action ("UIButton96_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton96_TouchUpInside (UIButton sender);

		[Action ("UIButton99_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton99_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnBack != null) {
				btnBack.Dispose ();
				btnBack = null;
			}
			if (MyLabel != null) {
				MyLabel.Dispose ();
				MyLabel = null;
			}
		}
	}
}
