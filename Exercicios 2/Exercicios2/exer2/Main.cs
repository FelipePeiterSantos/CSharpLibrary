using System;

namespace exer2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int aux = Convert.ToInt32(Console.ReadLine ());
			int QtsNum = 0;
			for (int i=1; i <= aux; i++) {
				if (i % 7 == 0){
					QtsNum++;
				}
			}
			Console.WriteLine("Qts numeros divisiveis por 7: {0}",QtsNum);
		}
	}
}
