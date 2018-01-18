using System;

namespace exer5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Insira nota final: ");
			float notaFinal = Convert.ToSingle (Console.ReadLine());
			if (notaFinal >= 7) {
				Console.WriteLine ("Voce esta aprovado!");
			} else if (notaFinal >= 4) {
				Console.WriteLine ("Voce precisa de prova complementar!");
			} else {
				Console.WriteLine ("Voce esta reprovado!");
			}
		}
	}
}
