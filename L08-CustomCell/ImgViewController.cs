using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace L08_CustomCell
{
	partial class ImgViewController : UIViewController
	{
        public string ImgName { get; set; }
		public ImgViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.MyImg.Image = UIImage.FromFile(ImgName);
        }
	}
}
