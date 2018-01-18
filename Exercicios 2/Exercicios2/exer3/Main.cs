using System;

namespace exer3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string maiorNome = "";
			string[] nomes = new string[10];
			for (int i=0;i<10;i++){
				Console.Write ("Nome numero {0}: ",i+1);
				nomes[i] = Console.ReadLine ();
			}
			foreach(string jogador in nomes){
				if (jogador.Length >= maiorNome.Length){
					maiorNome = jogador;
				}
			}
			Console.WriteLine ("Nome maior: {0}",maiorNome);
		}
	}
}
