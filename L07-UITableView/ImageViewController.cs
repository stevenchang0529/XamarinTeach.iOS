using System;
using Foundation;
using UIKit;
using System.CodeDom.Compiler;

namespace L07_UITableView
{
	partial class ImageViewController : UIViewController
	{
        public string ImageName { get; set; }
		public ImageViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            this.Image.Image = UIImage.FromFile(ImageName);
        }
	}
}
