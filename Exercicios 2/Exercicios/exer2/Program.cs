using System;

namespace exer2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Inserir primeiro numero entre 0 e 10 (peso 2): ");
			int num1 = Convert.ToInt32(Console.ReadLine ());
			if (num1 < 0 || num1 > 10){
				Console.WriteLine ("Numero não esta entre 0 e 10.");
				return;
			}
			Console.Write ("Inserir segundo numero entre 0 e 10 (peso 3): ");
			int num2 = Convert.ToInt32(Console.ReadLine ());
			if (num2 < 0 || num2 > 10){
				Console.WriteLine ("Numero não esta entre 0 e 10.");
				return;
			}
			int mediaFinal = (num1 * 2 + num2 * 3) / 2;
			Console.WriteLine ("Media Final: {0}",mediaFinal);
		}
	}
}
