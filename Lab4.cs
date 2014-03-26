using System;

namespace sum2
{
	class MainClass
	{
		public static void Main (string[] args)
		{	string num1 = Console.ReadLine();
			string num2 = Console.ReadLine();

			int num3 = int.Parse(num1);
			int num4 = int.Parse(num2);
			int sum = num3 + num4;

			Console.WriteLine ("첫 번째 값:{0},두 번째 값{1}:  합:{2}", num1, num2, sum);
		}
	}
}
