using System;
using System.Collections.Generic;
using System.Linq;

namespace Bowling {
	class Program {

		static int Bowl1Game(Random rnd) {

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
			return final;
		}

		static void Main(string[] args) {

			var rnd = new Random();
			var series = 0;
			var x = 1;
			var total = 0;
			while ( total <300 ){
				total = Bowl1Game(rnd);
				x++;
			}

			Console.WriteLine($"Score of 300 took {x} number of tries!!");
			//for (int i = 0; i < ; i++) {
			//	series += total;
			//	if (total >= 295);
			//}

			//Console.WriteLine($"Combined score = {series}");

		}
	}
}
