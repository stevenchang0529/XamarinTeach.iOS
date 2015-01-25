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
	[Register ("MyCell")]
	partial class MyCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel Age { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel Name { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (Age != null) {
				Age.Dispose ();
				Age = null;
			}
			if (Name != null) {
				Name.Dispose ();
				Name = null;
			}
		}
	}
}
