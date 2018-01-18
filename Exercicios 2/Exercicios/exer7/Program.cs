using System;

namespace exer7
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Escreva dois numeros:");
			int num1 = Convert.ToInt32 (Console.ReadLine());
			int num2 = Convert.ToInt32 (Console.ReadLine());
			if (num1 + num2 >= 10) {
				Console.WriteLine (num1 + num2);
			} else {
				Console.WriteLine ("Resultado final é menor que 10");
			}
		}
	}
}
