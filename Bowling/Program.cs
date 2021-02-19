using System;
using System.Collections.Generic;
using System.Linq;

namespace Bowling {
	class Program {
		static void Main(string[] args) {


			// generate 10 random frames (0-30) of bowling and print the final score.

			var rnd = new Random();
			var score = new List<int>(10);
			var final = 0;
			var msg = $"Scoreboard [";


			for (int i = 0; i < 10; i++) {
				var nbr = rnd.Next(0, 31);
				// score.Add(nbr); not needed?
				final += nbr;
				
				msg += i != 9 ? $"{nbr}, " : $"{nbr}]";
			}

			Console.WriteLine($"Final score is {final}.");
			Console.WriteLine(msg);
		}
	}
}
