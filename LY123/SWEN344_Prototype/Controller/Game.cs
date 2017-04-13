using System.Collections.Generic;
using System;

namespace SWEN344_Prototype
{
	public class Game
	{
		//private List<Question> questions;

		public List<Question> gameQuestions { get; set; }

		public List<Reward> rewards { get; set; }

		public User user { get; set; }

		public int score { get; set; }

		public Level currentLevel { get; set;}

		public int questionNum { get; set; }

		private string subject;

		private int grade;

		private bool gameOver;

		public int lives;

		public Game(string subject, int grade, List<Question> questions)
		{
			//this.questions = questions;
			this.subject = subject;
			this.grade = grade;
			questionNum = 0;
			gameQuestions = questions;
			rewards = new List<Reward>();
			score = 0;
			//questionSort();
			Level start = new Level();
			start.lvlnum = 1;
			List<Question> lvlquestions = new List<Question>();


			int i = 0;
			int c = 0;
			while (i < gameQuestions.Count && c < 10)
			{
				if (gameQuestions[i].complete == false)
				{
					lvlquestions.Add(gameQuestions[i]);
					c++;
				}
				i++;
			}

			start.questions = lvlquestions;
			Reward r = new Reward();
			r.name = "Extra Life";
			start.reward = r;
			currentLevel = start;
			lives = 3;
			gameOver = false;

		}



		//creates a new level

		//!!!!!!! need to make rewards randomly generated
		private Level newLevel()
		{
			if(questionNum >= gameQuestions.Count){
				return null;
			}

			int newNum = currentLevel.lvlnum + 1;

			Level l = new Level();
			l.lvlnum = newNum;
			l.reward = new Reward();

			//stubbed reward
			l.reward.name = "A High Five!";

			int i = 0;
			int c = 0;
			while(i < gameQuestions.Count && c < 10){
				if (gameQuestions[i].complete == false)
				{
					l.questions.Add(gameQuestions[i]);
					c++;
				}
				i++;
			}

			if(l.questions.Count < 1){
				gameOver = true;
			}

			return l;
		}

		//checks if the level is over, creates a new level if yes
		public bool endLevel(){
			if(questionNum % currentLevel.questions.Count == 0){
				rewards.Add(currentLevel.reward);
				//add reward text
				if(currentLevel.reward.name.Equals("Extra Life")){
					lives += 1;
					rewards.RemoveAt(rewards.Count - 1);
				}
				currentLevel = newLevel();
				if(currentLevel == null){
					gameOver = true;
				}
				return true;
			}
			return false;
		}

		//returns the next question
		public Question getNextQuestion(){
			return currentLevel.questions[questionNum % currentLevel.questions.Count];
		}

		//checks if correct answer
		public bool correct(Answer answer){
			if(gameOver == true){
				return false;
			}
			if (answer.correct)
			{
				score += answer.points;
				gameQuestions[questionNum].complete = true;
				questionNum += 1;
				if (questionNum >= gameQuestions.Count)
				{
					gameOver = true;
				}
				return true;
			}
			else
			{
				gameQuestions[questionNum].complete = true;
				questionNum += 1;

				gameOver = loseLife();

				if (questionNum >= gameQuestions.Count)
				{
					gameOver = true;
				}
				return false;
			}
		}

		public bool ifOver(){
			return gameOver;
		}

		//subtracts life. checks if lives are out.
		private bool loseLife(){
			lives = lives - 1;
			if(lives < 1){
				return true;
			}
			return false;
		}
	}
}
