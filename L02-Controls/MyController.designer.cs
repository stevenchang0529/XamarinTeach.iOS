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
	[Register ("MyController")]
	partial class MyController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIDatePicker datePick { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (datePick != null) {
				datePick.Dispose ();
				datePick = null;
			}
		}
	}
}
