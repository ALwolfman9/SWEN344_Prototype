using Foundation;
using System;
using UIKit;
using AudioToolbox;

namespace SWEN344_Prototype.iOS
{
	public partial class CorrectViewController : UIViewController
	{

		public Game game { get; set; }

		public Answer answer { get; set; }

		public Level level { get; set; }

		//NSUrl url;
		//SystemSound systemSound;

		public CorrectViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad(){
            this.NavigationController.ToolbarHidden = true;

			pointsLabel.Text = "+" + answer.points + " points!";

			//url = NSUrl.FromFilename ("Resources/Correct-answer.mp3");
			//systemSound = new SystemSound(url);
			//systemSound.PlayAlertSound();

			next.TouchUpInside += (object sender, EventArgs e) =>
			{
				if(game.ifOver()){
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