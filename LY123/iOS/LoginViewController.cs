using System;
using Foundation;
using UIKit;

namespace SWEN344_Prototype.iOS
{
	public partial class LoginViewController : UIViewController
	{
		public LoginViewController(IntPtr handle) : base(handle)
		{
			
		}

		public override void ViewDidLoad()
		{
			this.NavigationController.ToolbarHidden = true;

			//base.ViewDidLoad();
			enter.TouchUpInside += (object sender, EventArgs e) => {
				IndexViewController index = this.Storyboard.InstantiateViewController("Index") as IndexViewController;
				this.NavigationController.PushViewController(index, true);
			};
		}
	}
}