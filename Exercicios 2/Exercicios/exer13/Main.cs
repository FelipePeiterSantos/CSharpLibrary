using System;

namespace exer13
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write("Digite uma dia:");
			int dia = Convert.ToInt32(Console.ReadLine ());
			if (dia <1 || dia > 31){
				Console.WriteLine ("Data invalida.");
				return;
			}
			Console.Write("Digite um mes:");
			int mes = Convert.ToInt32(Console.ReadLine ());
			if (mes <1 || mes > 12){
				Console.WriteLine ("Mes invalido.");
				return;
			}
			Console.Write("Digite um ano:");
			int ano = Convert.ToInt32(Console.ReadLine ());
			if (ano <1){
				Console.WriteLine ("Ano invalido.");
				return;
			}
		}
	}
}
