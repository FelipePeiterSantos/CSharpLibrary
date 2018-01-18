using System;

namespace exer2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("Insira dano: ");
			int dano = Convert.ToInt32(Console.ReadLine ());
			Dano(dano);
		}
		static void Dano(int a)
		{
			int pontosPlayer = 10;
			Console.WriteLine ("Pontos do Player: {0}", pontosPlayer);
			while (pontosPlayer > 1)
			{
				pontosPlayer = pontosPlayer - a;
				Console.WriteLine ("Pontos restantes: {0}", pontosPlayer);
				Console.WriteLine("Insira dano: ");
				a = Convert.ToInt32(Console.ReadLine ());

			} 
		}
	}
}
