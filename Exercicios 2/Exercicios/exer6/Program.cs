using System;

namespace exer6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ConsoleKeyInfo  input = Console.ReadKey ();
			if (input.Key == ConsoleKey.F) {
				Console.WriteLine ("\nPessoa Fisica");
			} else if (input.Key == ConsoleKey.J) {
				Console.WriteLine ("\nPessoa Juridica");
			} else {
				Console.WriteLine ("\nPessoa Invalida");
			}
		}
	}
}
