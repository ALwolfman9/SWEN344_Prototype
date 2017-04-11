using System.Collections.Generic;
using System;

namespace SWEN344_Prototype
{
	public class Game
	{
		private List<Question> questions;

		public List<Question> gameQuestions { get; set; }

		public List<Reward> rewards { get; set; }

		public User user { get; set; }

		public int score { get; set; }

		private Level currentLevel;

		public int questionNum { get; set; }

		private string subject;

		private int grade;

		private bool gameOver;

		public int lives;

		public Game(string subject, int grade, List<Question> questions)
		{
			this.questions = questions;
			this.subject = subject;
			this.grade = grade;
			currentLevel = new Level();
			questionNum = 0;
			lives = 3;
			gameOver = false;
			questionSort();
		}

		private void questionSort(){
			gameQuestions = (questions);
		}
		private List<Question> sort(List<Question> list){
			if(list.Count > 2)return list;
			int tophalf = list.Count / 2;
			int bottomhalf = list.Count / 2 + 1;

			List<Question> a; 
			List<Question> b;

			if (list.Count % 2 == 0)
			{
				a = sort(list.GetRange(0, tophalf));
				b = sort(list.GetRange(bottomhalf, tophalf));
			}
			else{
				a = sort(list.GetRange(0, tophalf));
				b = sort(list.GetRange(tophalf, bottomhalf));
			}

			List<Question> c = new List<Question>();
			int i = 0;
			int j = 0;

			while(i < a.Count && j < b.Count){
				Question q = new Question();
				if(a[i].level <= b[j].level && i < a.Count){
					q = a[i];
					if(q.grade.Equals(grade) && q.subject.Equals(subject)){
						c.Add(q);
					}
					i++;
				}
				else if(a[i].level > b[j].level && j < b.Count){
					q = b[j];
					if(q.grade.Equals(grade) && q.subject.Equals(subject)){
						c.Add(q);
					}
					j++;
				}
				else if(j >= b.Count){
					q = a[i];
					if(q.grade.Equals(grade) && q.subject.Equals(subject)){
						c.Add(q);
					}
					i++;
				}
				else{
					q = b[j];
					if(q.grade.Equals(grade) && q.subject.Equals(subject)){
						c.Add(q);
					}
					j++;
				}
			}

			return c;
		}

		//creates a new level

		//!!!!!!! need to make rewards randomly generated
		private Level newLevel()
		{
			int newNum = currentLevel.lvlnum + 1;

			Level l = new Level();
			l.lvlnum = newNum;
			l.reward = new Reward();

			//stubbed reward
			l.reward.name = "A High Five!";

			for (int i = 0; i < 10; i++){
				l.questions.Add(gameQuestions[i]);
			}

			return l;
		}

		//checks if the level is over, creates a new level if yes
		public void endLevel(){
			if(questionNum % 10 == 0){
				rewards.Add(currentLevel.reward);
				//add reward text
				if(currentLevel.reward.name.Equals("Extra Life")){
					lives += 1;
					rewards.RemoveAt(rewards.Count - 1);
				}
				currentLevel = newLevel();
			}
		}

		//returns the next question
		public Question getNextQuestion(){
			return currentLevel.questions[questionNum % 10];
		}

		//checks if correct answer
		public bool correct(Answer answer){
			if(answer.correct){
				score += answer.points;
				questionNum += 1;
				return true;
			}
			gameOver = loseLife();
			return false;
		}

		public bool ifOver(){
			return gameOver;
		}

		//subtracts life. checks if lives are out.
		public bool loseLife(){
			lives = lives - 1;
			if(lives < 1){
				return true;
			}
			return false;
		}
	}
}
