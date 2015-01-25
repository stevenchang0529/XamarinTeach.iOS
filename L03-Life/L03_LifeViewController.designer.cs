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

namespace L03_Life
{
	[Register ("L03LifeViewController")]
	partial class L03LifeViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (lbl != null) {
				lbl.Dispose ();
				lbl = null;
			}
		}
	}
}
