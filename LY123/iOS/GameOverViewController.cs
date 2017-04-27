using Foundation;
using System;
using UIKit;

namespace SWEN344_Prototype.iOS
{
    public partial class GameOverViewController : UIViewController
    {
		public Game game { get; set; }

		public GameOverViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
            this.NavigationController.ToolbarHidden = true;

			scoreLabel.Text = "Total Score: " + game.score;
			rewardsCount.Text = "Rewards Gained: " + game.rewards.Count;

			quit.TouchUpInside += (object sender, EventArgs e) =>
			{
				IndexViewController index = this.Storyboard.InstantiateViewController("Index") as IndexViewController;
				this.NavigationController.PushViewController(index, true);
			};
		}
    }
}