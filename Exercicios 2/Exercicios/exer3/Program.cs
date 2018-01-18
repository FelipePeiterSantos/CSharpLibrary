using System;

namespace exer3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Insira um numero qualquer: ");
			float num1 = Convert.ToSingle (Console.ReadLine ());
			Console.Write ("Insira outro numero qualquer: ");
			float num2 = Convert.ToSingle (Console.ReadLine ());
			float aux = num1 + num2;
			Console.WriteLine ("{0} + {1} = {2}",num1,num2,Math.Round(aux,2));
			aux = num1 - num2;
			Console.WriteLine ("{0} - {1} = {2}",num1,num2,Math.Round(aux,2));
			aux = num1 * num2;
			Console.WriteLine ("{0} x {1} = {2}",num1,num2,Math.Round(aux,2));
			aux = num1 / num2;
			Console.WriteLine ("{0} / {1} = {2}",num1,num2,Math.Round(aux,2));
		}
	}
}