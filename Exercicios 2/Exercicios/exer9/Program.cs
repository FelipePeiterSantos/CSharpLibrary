using System;

namespace exer9
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Random rand = new Random ();
			int p1 = rand.Next (100);
			int p2 = rand.Next (100);
			Console.WriteLine ("Player 1 tem {0} pontos.\nPlayer 2 tem {1} pontos.\n",p1,p2);
			if (p1 > p2) {
				Console.WriteLine ("Player 1 ganha de Player 2.");
			} else if (p2 > p1) {
				Console.WriteLine ("Player 2 ganha de Player 1.");
			} else {
				Console.WriteLine ("Empatados.");
			}
		}
	}
}
