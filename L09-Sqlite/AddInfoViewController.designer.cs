// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using Foundation;
using UIKit;
using System.CodeDom.Compiler;

namespace L09_Sqlite
{
	[Register ("AddInfoViewController")]
	partial class AddInfoViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtAge { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtName { get; set; }

		[Action ("UIButton39_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton39_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (txtAge != null) {
				txtAge.Dispose ();
				txtAge = null;
			}
			if (txtName != null) {
				txtName.Dispose ();
				txtName = null;
			}
		}
	}
}
