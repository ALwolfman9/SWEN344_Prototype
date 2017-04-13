using System;

using UIKit;

namespace SWEN344_Prototype.iOS
{
	public partial class GameViewController : UIViewController
	{

		public Game game { get; set; }

		public GameViewController(IntPtr handle) : base(handle)
		{

		}

		public override void ViewDidLoad()
		{
            this.NavigationController.ToolbarHidden = true;

			Question current = game.getNextQuestion();
			Level cl = game.currentLevel;
			question.Text = game.getNextQuestion().name;
			answer1.SetTitle(game.getNextQuestion().answers[0].name, UIControlState.Normal);
			answer2.SetTitle(game.getNextQuestion().answers[1].name, UIControlState.Normal);
			answer3.SetTitle(game.getNextQuestion().answers[2].name, UIControlState.Normal);
			answer4.SetTitle(game.getNextQuestion().answers[3].name, UIControlState.Normal);

			answer1.TouchUpInside += (object sender, EventArgs e) =>
			{
				bool correct = game.correct(current.answers[0]);

				if (correct)
				{
					CorrectViewController c = this.Storyboard.InstantiateViewController("Correct") as CorrectViewController;
					c.game = game;
					c.answer = current.answers[0];
					c.level = cl;
					this.NavigationController.PushViewController(c, true);
				}
				else
				{
					IncorrectViewController i = this.Storyboard.InstantiateViewController("Incorrect") as IncorrectViewController;
					i.game = game;
					i.level = cl;
					this.NavigationController.PushViewController(i, true);
				}


			};
			answer2.TouchUpInside += (object sender, EventArgs e) =>
			{
				bool correct = game.correct(current.answers[1]);

				if (correct)
				{
					CorrectViewController c = this.Storyboard.InstantiateViewController("Correct") as CorrectViewController;
					c.game = game;
					c.answer = current.answers[1];
					c.level = cl;
					this.NavigationController.PushViewController(c, true);
				}
				else
				{
					IncorrectViewController i = this.Storyboard.InstantiateViewController("Incorrect") as IncorrectViewController;
					i.game = game;
					i.level = cl;
					this.NavigationController.PushViewController(i, true);
				}

			};
			answer3.TouchUpInside += (object sender, EventArgs e) =>
			{
				bool correct = game.correct(current.answers[2]);

				if (correct)
				{
					CorrectViewController c = this.Storyboard.InstantiateViewController("Correct") as CorrectViewController;
					c.game = game;
					c.answer = current.answers[2];
					c.level = cl;
					this.NavigationController.PushViewController(c, true);
				}
				else
				{
					IncorrectViewController i = this.Storyboard.InstantiateViewController("Incorrect") as IncorrectViewController;
					i.game = game;
					i.level = cl;
					this.NavigationController.PushViewController(i, true);
				}

			};
			answer4.TouchUpInside += (object sender, EventArgs e) =>
			{
				bool correct = game.correct(current.answers[3]);

				if (correct)
				{
					CorrectViewController c = this.Storyboard.InstantiateViewController("Correct") as CorrectViewController;
					c.game = game;
					c.answer = current.answers[3];
					c.level = cl;
					this.NavigationController.PushViewController(c, true);
				}
				else
				{
					IncorrectViewController i = this.Storyboard.InstantiateViewController("Incorrect") as IncorrectViewController;
					i.game = game;
					i.level = cl;
					this.NavigationController.PushViewController(i, true);
				}


			};
		}
	}



}