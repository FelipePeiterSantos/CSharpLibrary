using System;

namespace exer1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("Selecione Menu:\n1-Iniciar\n2-Opçoes\n3-Creditos\n4-Sair\n");
			int num = Convert.ToInt32(Console.ReadLine());
			if (num == 1){
				Iniciar();
			}
			else if (num == 2){
				Opcoes();
			}
			else if (num == 3){
				Creditos();
			}
			else if (num == 4){
				Sair();
			}
			else {
				Error();
			}
		}
		static void Iniciar()
		{
			Console.WriteLine ("MENU:\nEntrou Iniciar");
		}
		static void Opcoes()
		{
			Console.WriteLine ("MENU:\nEntrou Opcoes");
		}
		static void Creditos()
		{
			Console.WriteLine ("MENU:\nEntrou Creditos");
		}
		static void Sair()
		{
			Console.WriteLine ("MENU:\nEntrou Sair");
		}
		static void Error()
		{
			Console.WriteLine ("MENU:\nError ");
		}
	}
}
