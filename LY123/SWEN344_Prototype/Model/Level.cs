using System;
using System.Collections.Generic;

namespace SWEN344_Prototype
{

	//Game Level not question Level
	public class Level
	{
		public Level()
		{
			
		}

		public int lvlnum { get; set; }

		public List<Question> questions { get; set; }

		public Reward reward { get; set; }
	}
}
