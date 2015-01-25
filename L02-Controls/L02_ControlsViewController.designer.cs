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

namespace L02_Controls
{
	[Register ("L02ControlsViewController")]
	partial class L02ControlsViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnClick { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView MyView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISegmentedControl seg { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtField { get; set; }

		[Action ("UIButton41_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton41_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnClick != null) {
				btnClick.Dispose ();
				btnClick = null;
			}
			if (lblText != null) {
				lblText.Dispose ();
				lblText = null;
			}
			if (MyView != null) {
				MyView.Dispose ();
				MyView = null;
			}
			if (seg != null) {
				seg.Dispose ();
				seg = null;
			}
			if (txtField != null) {
				txtField.Dispose ();
				txtField = null;
			}
		}
	}
}
