using System;
using System.Collections.Generic;

namespace SWEN344_Prototype
{
	public class Student : User
	{
		public Student()
		{
		}

		public int grade { get; set; }

		public List<Reward> rewards { get; set; }

		public List<int> top_scores { get; set; }
	}
}
