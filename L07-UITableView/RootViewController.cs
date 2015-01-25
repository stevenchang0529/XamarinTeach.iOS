using System;
using System.Drawing;

using Foundation;
using UIKit;
using System.Collections.Generic;

namespace L07_UITableView
{
    public partial class RootViewController : UIViewController
    {
        public RootViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            MyTableSource source = new MyTableSource()
            {
                Context=this,
                Items = new List<Data>()
                {
                    new Data(){ Title="淡淡的哀傷",Image="01.png"},
                    new Data(){ Title="名義老爸",Image="02.png"},
                    new Data(){ Title="心中的一團火",Image="03.png"},
                    new Data(){ Title="非常好",Image="04.png"},
                    new Data(){ Title="回火星",Image="05.jpg"},
                    new Data(){ Title="是畜生",Image="06.png"},
                    new Data(){ Title="好人",Image="07.png"},
                    new Data(){ Title="關門放狗",Image="08.jpg"}
                }
            };
            MyTable.Source = source;


            this.NavigationItem.SetRightBarButtonItem(new UIBarButtonItem("EDIT", UIBarButtonItemStyle.Plain, (sender, e) =>
            {

                var button = sender as UIBarButtonItem;
                if (button.Title == "EDIT")
                {
                    button.Title = "DONE";
                    MyTable.SetEditing(true, true);
                }
                else
                {
                    button.Title = "EDIT";
                    MyTable.SetEditing(false, true);
                }


            }), true);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion
    }

    public class MyTableSource:UITableViewSource
    {
        public List<Data> Items;
        public UIViewController Context;
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
           var cell= tableView.DequeueReusableCell("ID");
           if (cell == null)
           {
               cell = new UITableViewCell(UITableViewCellStyle.Default, "ID");
           }
           cell.TextLabel.Text = Items[indexPath.Row].Title;
           cell.ImageView.Image = UIImage.FromFile(Items[indexPath.Row].Image);
         
           return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var controller=UIStoryboard.FromName("MainStoryboard",null).InstantiateViewController("ImageViewController") as ImageViewController;
            controller.ImageName = this.Items[indexPath.Row].Image;
            Context.NavigationController.PushViewController(controller,true);
        }

        public override bool CanEditRow(UITableView tableView, NSIndexPath indexPath)
        {
            return true;
        }

        public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
        {
            if (editingStyle == UITableViewCellEditingStyle.Delete)
            {
                Items.RemoveAt(indexPath.Row);
                tableView.DeleteRows(new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Fade);
            }
        }

        public override UITableViewCellEditingStyle EditingStyleForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return UITableViewCellEditingStyle.Delete;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return Items.Count;
        }
    }

    public class Data
    {
        public string Title{get;set;}
        public string Image{get;set;}
    }
}