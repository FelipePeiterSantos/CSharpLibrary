using System;

namespace exer1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Inserir primeiro numero: ");
			string string1 = Console.ReadLine ();
			Console.Write ("Inserir segundo numero: ");
			string string2 = Console.ReadLine ();
			Console.Write ("Inserir terceiro numero: ");
			string string3 = Console.ReadLine ();
			if (string1 != "") {
				int num1 = Convert.ToInt32 (string1);
				int num2 = Convert.ToInt32 (string2);
				int num3 = Convert.ToInt32 (string3);
				int mediaFinal = (num1 + num2 + num3) / 3;
				Console.WriteLine ("Media Final: {0}", mediaFinal);
			} else {
				Console.WriteLine ("Nao foi possivel calcular media, faltou numero.");
				return;
			}
		}
	}
}
