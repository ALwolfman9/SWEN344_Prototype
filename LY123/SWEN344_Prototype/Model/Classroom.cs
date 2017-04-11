using System;
using System.Collections.Generic;

namespace SWEN344_Prototype
{
	public class Classroom
	{
		public Classroom()
		{
		}

		public int grade { get; set; }

		public List<string> subjects { get; set; }

		public Teacher teacher { get; set; }

		public List<Student> students { get; set; }

		public Reward class_reward { get; set; }

		public List<Question> questions { get; set; }
	}
}
