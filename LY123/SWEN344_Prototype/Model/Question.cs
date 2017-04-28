using System;
using System.Collections.Generic;

namespace SWEN344_Prototype
{
	public class Question
	{
		public Question()
		{
		}

		public string name { get; set; }

		public List<Answer> answers { get; set; }

		public bool complete { get; set; }

		public string subject { get; set; }

		public int grade { get; set; }

		//Ranges from 1 - 10. Does not decide Game Level
		public int level { get; set; }

		public Classroom classroom { get; set; }

		public string imageString { get; set; }
	}
}
