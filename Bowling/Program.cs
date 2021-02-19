using System;
using System.Collections.Generic;
using System.Linq;

namespace Bowling {
	class Program {

		static void Bowl1Game(Random rnd) {

			var score = new List<int>(10);
			var final = 0;
			var msg = $"Scoreboard [";


			for (int i = 0; i < 10; i++) {
				var nbr = rnd.Next(0, 31);
				score.Add(nbr);
				
				msg += i != 9 ? $"{nbr}, " : $"{nbr}]";
			}

			foreach (var item in score) {
				final += item;
			}

			Console.WriteLine(msg);
			Console.WriteLine($"Final score is {final}.\n");

		}
		static void Main(string[] args) {

			var rnd = new Random();
			for (int i = 0; i < 3; i++) {
				Bowl1Game(rnd);
			}

		}
	}
}
