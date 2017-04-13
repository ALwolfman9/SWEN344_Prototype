using System;

using UIKit;

namespace SWEN344_Prototype.iOS
{
	public partial class IndexViewController : UIViewController
	{
		public IndexViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			//base.ViewDidLoad();

            this.NavigationController.ToolbarHidden = true;

			StubQuestions stubs = new StubQuestions();

			Game game = new Game(stubs.subject, stubs.grade, stubs.questions);

			Play.TouchUpInside += (object sender, EventArgs e) =>
			{
				GameViewController theGame = this.Storyboard.InstantiateViewController("Game") as GameViewController;
				theGame.game = game;
				this.NavigationController.PushViewController(theGame, true);
			};

			SignOut.TouchUpInside += (object sender, EventArgs e) =>
			{
				LoginViewController login = this.Storyboard.InstantiateViewController("Login") as LoginViewController;
				this.NavigationController.PushViewController(login, true);
			};
		}
	}
}
