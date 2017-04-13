using Foundation;
using System;
using UIKit;

namespace SWEN344_Prototype.iOS
{
	public partial class IncorrectViewController : UIViewController
	{
		public Game game { get; set; }

		public Level level { get; set; }

		public IncorrectViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
            this.NavigationController.ToolbarHidden = true;

			lifeLabel.Text = "Lives: " + game.lives;

			next.TouchUpInside += (object sender, EventArgs e) =>
			{
				if (game.ifOver())
				{
					GameOverViewController go = this.Storyboard.InstantiateViewController("GameOver") as GameOverViewController;
					go.game = game;
					this.NavigationController.PushViewController(go, true);
				}
				else if (game.endLevel())
				{
					LevelUpViewController lu = this.Storyboard.InstantiateViewController("LevelUp") as LevelUpViewController;
					lu.game = game;
					lu.level = level;
					this.NavigationController.PushViewController(lu, true);
				}
				else
				{
					GameViewController theGame = this.Storyboard.InstantiateViewController("Game") as GameViewController;
					theGame.game = game;
					this.NavigationController.PushViewController(theGame, true);
				}
			};

			quit.TouchUpInside += (object sender, EventArgs e) =>
			{
				IndexViewController index = this.Storyboard.InstantiateViewController("Index") as IndexViewController;
				this.NavigationController.PushViewController(index, true);
			};
		}

	}
}