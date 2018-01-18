using System;

namespace exer8
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite um numero: ");
			int num = Convert.ToInt32 (Console.ReadLine());
			bool divisivel = true;
			if (num % 10 == 0){
				Console.WriteLine ("{0} é divisivel por 10.", num);
				divisivel = false;
			}
			if (num % 5 == 0){
				Console.WriteLine ("{0} é divisivel por 5.", num);
				divisivel = false;
			}
			if (num % 2 == 0){
				Console.WriteLine ("{0} é divisivel por 2.", num);
				divisivel = false;
			}
			if (divisivel) {
				Console.WriteLine ("{0} nao é divisivel por 10 ou 5 ou 2.", num);
			}
		}
	}
}
