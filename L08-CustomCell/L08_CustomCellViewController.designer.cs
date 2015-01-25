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
	[Register ("L08CustomCellViewController")]
	partial class L08CustomCellViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView MyTable { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (MyTable != null) {
				MyTable.Dispose ();
				MyTable = null;
			}
		}
	}
}
