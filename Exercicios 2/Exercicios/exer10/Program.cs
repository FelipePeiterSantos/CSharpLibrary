using System;

namespace exer10
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Random rand = new Random ();
			int p1 = rand.Next (100);
			int p2 = rand.Next (100);
			int p3 = rand.Next (100);
			int p4 = rand.Next (100);
			int p5 = rand.Next (100);
			Console.WriteLine ("Player 1 tem {0} pontos.\nPlayer 2 tem {1} pontos.\nPlayer 3 tem {2} pontos.\nPlayer 4 tem {3} pontos.\nPlayer 5 tem {4} pontos.\n",p1,p2,p3,p4,p5);
			int[] sortP = {p1,p2,p3,p4,p5};
			Array.Sort (sortP);
			if (sortP[4] == p1){
				Console.WriteLine ("Player 1 ficou em primeiro.");
			} else if (sortP[4] == p2){
				Console.WriteLine ("Player 2 ficou em primeiro.");
			} else if (sortP[4] == p3){
				Console.WriteLine ("Player 3 ficou em primeiro.");
			} else if (sortP[4] == p4){
				Console.WriteLine ("Player 4 ficou em primeiro.");
			} else if (sortP[4] == p5){
				Console.WriteLine ("Player 5 ficou em primeiro.");
			}
			if (sortP[0] == p1){
				Console.WriteLine ("Player 1 ficou em ultimo.");
			} else if (sortP[0] == p2){
				Console.WriteLine ("Player 2 ficou em ultimo.");
			} else if (sortP[0] == p3){
				Console.WriteLine ("Player 3 ficou em ultimo.");
			} else if (sortP[0] == p4){
				Console.WriteLine ("Player 4 ficou em ultimo.");
			} else if (sortP[0] == p5){
				Console.WriteLine ("Player 5 ficou em ultimo.");
			}
		}
	}
}
