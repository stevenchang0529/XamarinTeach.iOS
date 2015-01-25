using System;
using Foundation;
using UIKit;
using System.CodeDom.Compiler;
using L09_Sqlite.Service;

namespace L09_Sqlite
{
	partial class AddInfoViewController : UIViewController
	{
        public event EventHandler<Info> OnAdd;
        public bool HasEvent = false; 
		public AddInfoViewController (IntPtr handle) : base (handle)
		{
		}

        partial void UIButton39_TouchUpInside(UIButton sender)
        {
            this.NavigationController.PopViewController(true);
            if (OnAdd != null)
            {
                OnAdd(null, new Info()
                {
                     Age=this.txtAge.Text,
                      Name=this.txtName.Text
                });
            }
        }
	}
}
