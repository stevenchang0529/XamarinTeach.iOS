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

namespace L08_CustomCell
{
	[Register ("ImgViewController")]
	partial class ImgViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView MyImg { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (MyImg != null) {
				MyImg.Dispose ();
				MyImg = null;
			}
		}
	}
}
