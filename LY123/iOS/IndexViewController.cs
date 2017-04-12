using System;

using UIKit;

namespace SWEN344_Prototype.iOS
{
	public partial class IndexViewController : UIViewController
	{
		public IndexViewController() : base("IndexViewController", null)
		{
		}

		//partial void Clicked(UIButton sender)
		//{
		//	throw new NotImplementedException();
		//}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

