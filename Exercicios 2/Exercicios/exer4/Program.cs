using System;

namespace exer4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Random rand = new Random ();
			int num1 = rand.Next(0, 100);
			int num2 = rand.Next(0, 100);
			if (num1 > num2){
				Console.WriteLine ("{0} maior que {1}.",num1,num2);
			} else if (num1 < num2){
				Console.WriteLine ("{0} menor que {1}.",num1,num2);
			} else if (num1 == num2){
				Console.WriteLine ("{0} e {1} são iguais.",num1,num2);
			}
		}
	}
}
