using System;

namespace exer1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int aux = 0;
			int NumPares = 0;
			int QtsNum = 0;
			while (aux >= 0){
				QtsNum++;
				if (aux % 2 == 0){
					NumPares++;
				}
			}
			Console.WriteLine ("Qts numero pares:{0}\nQts numeros:{1}",NumPares,QtsNum);
		}
	}
}
 