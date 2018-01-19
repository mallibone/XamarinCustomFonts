using System;
using PureLayout.Net;
using UIKit;

namespace CustomFont
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var label = new UILabel
            {
                Text = "are easy & fun",
                Font = UIFont.FromName("GreatVibes-Regular", 32f),

            };

            View.BackgroundColor = UIColor.White;
            View.AddSubview(label);

            label.AutoPinEdge(ALEdge.Top, ALEdge.Bottom, StoryboardLabel, 32f);
            label.AutoAlignAxisToSuperviewAxis(ALAxis.Vertical);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
