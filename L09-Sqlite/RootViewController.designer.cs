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
	[Register ("RootViewController")]
	partial class RootViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView MyTable { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtKey { get; set; }

		[Action ("UIButton33_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton33_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (MyTable != null) {
				MyTable.Dispose ();
				MyTable = null;
			}
			if (txtKey != null) {
				txtKey.Dispose ();
				txtKey = null;
			}
		}
	}
}
