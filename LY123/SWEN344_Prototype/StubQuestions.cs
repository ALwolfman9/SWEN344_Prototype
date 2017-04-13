using System.Collections.Generic;

namespace SWEN344_Prototype
{
	public class StubQuestions
	{

		public List<Question> questions { get; set; }

		public string subject { get; set; }

		public int grade { get; set; }

		public StubQuestions()
		{
			questions = new List<Question>();

			grade = 0;
			subject = "Math";
			List<Answer> answers = new List<Answer>();
			Answer answer1 = new Answer();
			Answer answer2 = new Answer();
			Answer answer3 = new Answer();
			Answer answer4 = new Answer();

			//questions
			Question one = new Question();
			one.name = "1,2,3,_?";
			one.grade = 0;
			one.level = 1;
			one.subject = "Math";
			one.complete = false;
			one.classroom = null;
			answer1.name = "1";
			answer1.points = one.level * 100;
			answer1.correct = false;
			answers.Insert(0,answer1);
			answer2.name = "2";
			answer2.points = one.level * 100;
			answer2.correct = false;
			answers.Insert(1,answer2);
			answer3.name = "3";
			answer3.points = one.level * 100;
			answer3.correct = false;
			answers.Insert(2,answer3);
			answer4.name = "4";
			answer4.points = one.level * 100;
			answer4.correct = true;
			answers.Insert(3,answer4);
			one.answers = answers;
			questions.Add(one);


			List<Answer> answers2 = new List<Answer>();
			answers2.Capacity = 4;
			Answer answer1a = new Answer();
			Answer answer2a = new Answer();
			Answer answer3a = new Answer();
			Answer answer4a = new Answer();
			Question two = new Question();
			two.name = "4,5,6,_?";
			two.grade = 0;
			two.level = 1;
			two.subject = "Math";
			two.complete = false;
			two.classroom = null;
			answer1a.name = "1";
			answer1a.points = one.level * 100;
			answer1a.correct = false;
			answers2.Insert(0, answer1a);
			answer2a.name = "2";
			answer2a.points = one.level * 100;
			answer2a.correct = false;
			answers2.Insert(1, answer2a);
			answer3a.name = "3";
			answer3a.points = one.level * 100;
			answer3a.correct = false;
			answers2.Insert(2, answer3a);
			answer4a.name = "7";
			answer4a.points = one.level * 100;
			answer4a.correct = true;
			answers2.Insert(3, answer4a);
			two.answers = answers2;
			questions.Add(two);
		}
	}
}
