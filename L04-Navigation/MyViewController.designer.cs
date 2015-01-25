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
	[Register ("MyViewController")]
	partial class MyViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblTest { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtValue { get; set; }

		[Action ("UIButton64_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton64_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (lblTest != null) {
				lblTest.Dispose ();
				lblTest = null;
			}
			if (txtValue != null) {
				txtValue.Dispose ();
				txtValue = null;
			}
		}
	}
}
