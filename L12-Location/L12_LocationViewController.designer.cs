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

namespace L12_Location
{
	[Register ("L12LocationViewController")]
	partial class L12LocationViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView address { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel alt { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel head { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lat { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lon { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (address != null) {
				address.Dispose ();
				address = null;
			}
			if (alt != null) {
				alt.Dispose ();
				alt = null;
			}
			if (head != null) {
				head.Dispose ();
				head = null;
			}
			if (lat != null) {
				lat.Dispose ();
				lat = null;
			}
			if (lon != null) {
				lon.Dispose ();
				lon = null;
			}
		}
	}
}
