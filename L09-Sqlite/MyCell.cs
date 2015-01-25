using System;
using Foundation;
using UIKit;
using System.CodeDom.Compiler;
using L09_Sqlite.Service;

namespace L09_Sqlite
{
	partial class MyCell : UITableViewCell
	{
		public MyCell (IntPtr handle) : base (handle)
		{
		}

        public void SetData(Info data)
        {
            this.Name.Text = data.Name;
            this.Age.Text = data.Age;
        }
	}
}
