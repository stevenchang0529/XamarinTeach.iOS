using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;

namespace L08_CustomCell
{
    public partial class L08CustomCellViewController : UIViewController
    {
        public L08CustomCellViewController(IntPtr handle)
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
        MyTableSource source;
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

             source = new MyTableSource()
            {
                Context = this,
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
        }


        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            var controller=segue.DestinationViewController as ImgViewController;
            controller.ImgName = source.Items[this.MyTable.IndexPathForSelectedRow.Row].Image;
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

    public class MyTableSource : UITableViewSource
    {
        public List<Data> Items;
        public UIViewController Context;
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
           var cell= tableView.DequeueReusableCell("MyCell") as MyCell;
           cell.SetData(Items[indexPath.Row]);
           return cell;
        }

        public override int RowsInSection(UITableView tableview, int section)
        {
            return Items.Count;
        }
    }
}