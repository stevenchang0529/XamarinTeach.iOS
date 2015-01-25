using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace L08_CustomCell
{
	partial class MyCell : UITableViewCell
	{
		public MyCell (IntPtr handle) : base (handle)
		{
		}

        public void SetData(Data data)
        {
            this.MyLabel.Text = data.Title;
            this.MyImg.Image = UIImage.FromFile(data.Image);
        }
        
	}
}
