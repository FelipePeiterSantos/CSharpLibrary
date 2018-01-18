using System;

namespace exer4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int input = Convert.ToInt32(Console.ReadLine());
			switch (input){
			case 1:
				Console.WriteLine("num 1");
				break;
			case 2:
				Console.WriteLine("num 2");
				break;
			case 3:
				Console.WriteLine("num 3");
				break;
			case 4:
				Console.WriteLine("num 4");
				break;
			default:
				Console.WriteLine("nao e 1 ou 2 ou 3 ou 4");
				break;
			}
		}
	}
}
